using NewMaui.Data;
using NewMaui.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;




namespace NewMaui.Pages.Service.PostService;

public partial class Post1 : ContentPage, INotifyPropertyChanged
{
    private PartsData partsData = new PartsData();
    private ObservableCollection<Part> selectedParts = new ObservableCollection<Part>();
    public ObservableCollection<Part> SelectedParts
    {
        get { return selectedParts; }
        set
        {
            selectedParts = value;
            OnPropertyChanged(nameof(SelectedParts));
        }
    }
    private List<GetCustomers> _customers;
    public List<GetCustomers> Customers
    {
        get { return _customers; }
        set
        {
            _customers = value;
            OnPropertyChanged(nameof(Customers));
        }
    }

    private GetCustomers _selectedCustomer;
    public GetCustomers SelectedCustomer
    {
        get { return _selectedCustomer; }
        set
        {
            if (_selectedCustomer != value)
            {
                _selectedCustomer = value;
                OnPropertyChanged(nameof(SelectedCustomer));

                // Update Machines when SelectedCustomer changes
                if (_selectedCustomer != null)
                {
                    Machines = _selectedCustomer.Machines;
                }
            }
        }
    }

    private List<NewMaui.Model.Machine> _machines;
    public List<NewMaui.Model.Machine> Machines
    {
        get { return _machines; }
        set
        {
            _machines = value;
            OnPropertyChanged(nameof(Machines));
        }
    }

    private NewMaui.Model.Machine _selectedMachine;
    public NewMaui.Model.Machine SelectedMachine
    {
        get { return _selectedMachine; }
        set
        {
            if (_selectedMachine != value)
            {
                _selectedMachine = value;
                OnPropertyChanged(nameof(SelectedMachine));
            }
        }
    }
    private object service;
    public object Service;


    public Post1()
    {
        InitializeComponent();
        BindingContext = this;
        LoadCustomersAsync();
        LoadServicePartsAsync();

    }

    public async Task LoadCustomersAsync()
    {
        CustomerData customerData = new CustomerData();
        Customers = await customerData.GetCustomersAsync();
        if (SelectedCustomer != null)
        {
            Machines = SelectedCustomer.Machines;
        }
    }

    private async void OnButton_Clicked(object sender, EventArgs e)
    {
        if (SelectedCustomer == null)
        {
            await DisplayAlert("Error", "Vælg en kunde", "OK");
            return;
        }
        if (SelectedMachine == null)
        {
            await DisplayAlert("Error", "Vælg en maskine", "OK");
            return;
        }

        // Convert the ObservableCollection to a List
        List<Part> selectedPartsList = SelectedParts.Select(part =>
        {
            part.PartsUsed = GetPartsUsedValue(part);
            return part;
        }).ToList();

        // Get the values from the input fields
        int transportTimeUsed = int.Parse(transportTimeEntry.Text);
        int transportKmUsed = int.Parse(kmEntry.Text);
        int workTimeUsed = int.Parse(workTimeEntry.Text);
        string machineStatus = statusEntry.Text;
        string note = noteEntry.Text;

        ServiceData serviceData = new ServiceData();
        await serviceData.PostServiceDataAsync(
            SelectedCustomer.CustomerID,
            SelectedMachine.MachineID,
            SelectedMachine.MachineSerialNumber,
            selectedPartsList, // Pass the List<Part> instead of ObservableCollection<Part>
            transportTimeUsed,
            transportKmUsed,
            workTimeUsed,
            note,
            machineStatus);
        await DisplayAlert("Succes", "Det indtastede service er nu oprettet", "OK");
        await Navigation.PushAsync(new NewMaui.Service());
    }
    public async Task LoadServicePartsAsync()
    {
        var parts = await partsData.GetPartsAsync();
        foreach (var part in parts)
        {
            var picker = new Picker
            {
                ItemsSource = parts,
                ItemDisplayBinding = new Binding("PartName"),
                Title = "Reservedel:",
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold,
                HeightRequest = 80
            };
            picker.SelectedIndexChanged += OnPickerSelectedIndexChanged;

            var entry = new Entry
            {
                Placeholder = "Indtast antal",
                FontSize = 20,
                Keyboard = Keyboard.Numeric
            };
            entry.TextChanged += OnEntryTextChanged;

            var stackLayout = new StackLayout();
            stackLayout.Children.Add(picker);
            stackLayout.Children.Add(entry);

            PickerStackLayout.Children.Add(stackLayout);
        }
    }

    private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var stackLayout = (StackLayout)entry.Parent;
        var picker = (Picker)stackLayout.Children[0];
        var selectedPart = (Part)picker.SelectedItem;
        if (selectedPart != null)
        {
            int PartsUsed;
            if (int.TryParse(entry.Text, out PartsUsed))
            {
                selectedPart.PartsUsed = PartsUsed;
            }
            else
            {
                selectedPart.PartsUsed = 0;
            }
        }
    }

    private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        var selectedPart = (Part)picker.SelectedItem;
        if (selectedPart != null)
        {
            SelectedParts.Add(selectedPart);
        }
    }
    private void OnClearSelectionClicked(object sender, EventArgs e)
    {
        foreach (var picker in PickerStackLayout.Children.OfType<Picker>())
        {
            picker.SelectedItem = null;
        }
    }
    private void OnAddPartClicked(object sender, EventArgs e)
    {
        foreach (var picker in PickerStackLayout.Children.OfType<Picker>())
        {
            var selectedPart = (Part)picker.SelectedItem;
            if (selectedPart != null)
            {
                SelectedParts.Add(selectedPart);
                picker.SelectedItem = null; // Reset the selected item
            }
        }
    }
    private int GetPartsUsedValue(Part part)
    {
        foreach (var stackLayout in PickerStackLayout.Children.OfType<StackLayout>())
        {
            var picker = (Picker)stackLayout.Children[0];
            var selectedPart = (Part)picker.SelectedItem;
            if (selectedPart == part)
            {
                var entry = (Entry)stackLayout.Children[1];
                if (int.TryParse(entry.Text, out int partsUsed))
                {
                    return partsUsed;
                }
            }
        }

        return 0;
    }

}
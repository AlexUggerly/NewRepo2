using NewMaui.Data;
using NewMaui.Model;
using System.ComponentModel;
using System.Reflection.PortableExecutable;


namespace NewMaui.Pages.Service.PostService;

public partial class Post1 : ContentPage, INotifyPropertyChanged
{
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
    

    public Post1()
    {
        InitializeComponent();
        BindingContext = this;
        LoadCustomersAsync();
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
        await Navigation.PushAsync(new Post2());
    }
}
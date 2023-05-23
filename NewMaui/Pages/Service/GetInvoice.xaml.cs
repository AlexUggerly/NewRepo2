namespace NewMaui.Pages.Service;
using NewMaui.Data;
using NewMaui.Model;
using System.ComponentModel;

public partial class GetInvoice : ContentPage, INotifyPropertyChanged
{
    private List<GetService> _services;
    public int SelectedServiceID { get; set; }


    public List<GetService> services
    {
        get { return _services; }
        set
        {
            _services = value;
            OnPropertyChanged(nameof(services));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public GetInvoice()
        {
        InitializeComponent();
        BindingContext = this;
        LoadDataAsync();
    }

    public async Task LoadDataAsync()
    {
        ServiceData serviceData = new ServiceData();
        services = await serviceData.GetServicesAsync();
    }

    private async void OnServiceClicked(object sender, EventArgs e)
    {
        var selectedService = (sender as Grid).BindingContext as GetService;
        SelectedServiceID = selectedService.ServiceID;
        await Navigation.PushAsync(new InvoiceDetails(SelectedServiceID));
    }


    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}






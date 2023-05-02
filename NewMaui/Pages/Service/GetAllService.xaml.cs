namespace NewMaui.Pages.Service;
using NewMaui.Model;
using NewMaui.Data;
using System.ComponentModel;

public partial class GetAllService : ContentPage, INotifyPropertyChanged
{
    private List<GetService> _services;

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

    public GetAllService()
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
        await Navigation.PushAsync(new ServiceDetails(selectedService));
    }

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

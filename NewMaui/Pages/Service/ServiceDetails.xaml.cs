namespace NewMaui.Pages.Service;
using NewMaui.Model;
using System.ComponentModel;

public partial class ServiceDetails : ContentPage
{
    public ServiceDetails(GetService service)
    {

        InitializeComponent();
        BindingContext = service;
        
    }

}

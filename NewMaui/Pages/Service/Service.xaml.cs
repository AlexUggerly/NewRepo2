using NewMaui.Model;
using NewMaui.Pages;
using NewMaui.Pages.Service;
using NewMaui.Pages.Service.PostService;
using System.Collections;


namespace NewMaui;

public partial class Service : ContentPage
{
	public Service()
	{
		InitializeComponent();
	}
    private async void OnLabelClickedAllServices(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetAllService());
    }
    private async void OnLabelClickedPostService(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Post1());
    }
    private async void OnLabelClickedInvoice(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetInvoice());
    }
    
}
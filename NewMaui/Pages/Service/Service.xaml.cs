using NewMaui.Model;
using NewMaui.Pages;
using NewMaui.Pages.Service;
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
        await Navigation.PushAsync(new GetAllParts());
    }

}
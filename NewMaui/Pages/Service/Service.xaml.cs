using NewMaui.Model;
using NewMaui.Pages;
using System.Collections;

namespace NewMaui;

public partial class Service : ContentPage
{
	public Service()
	{
		InitializeComponent();
	}
    private async void Back_OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Menu());
    }
    private async void OnLabelClickedAllParts(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetAllParts());
    }
    private async void OnLabelClickedAllServices(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetMachineParts());
    }

}
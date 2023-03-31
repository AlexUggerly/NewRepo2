using NewMaui.Pages;
using NewMaui.Pages.Parts;

namespace NewMaui;

public partial class Parts : ContentPage
{
	public Parts()
	{
		InitializeComponent();
	}
    private async void OnLabelClickedInventory(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GetAllParts());
    }
    private async void OnLabelClickedInventoryUpdate(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UpdateParts());
    }
    private async void OnLabelClickedPostNewPart(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PostNewPart());
    }
}
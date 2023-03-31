namespace NewMaui.Pages.Parts;

public partial class UpdateParts : ContentPage
{
	public UpdateParts()
	{
		InitializeComponent();
	}
    private async void OnLabelClickedDelete(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DeletePart());
    }
    private async void OnLabelClickedChange(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ModifyPart());
    }
}
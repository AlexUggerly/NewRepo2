namespace NewMaui;


public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
    private async void OnLabelClickedService(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Service());
    }
    private async void OnLabelClickedReservedele(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Parts());
    }
    
}
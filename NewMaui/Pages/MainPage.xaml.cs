namespace NewMaui;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();

    }

    private async void OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Menu());
    }
}


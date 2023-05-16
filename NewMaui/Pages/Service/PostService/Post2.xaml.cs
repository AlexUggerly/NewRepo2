namespace NewMaui.Pages.Service.PostService;

public partial class Post2 : ContentPage
{
	public Post2()
	{
		InitializeComponent();
	}
    private async void OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Post2());
    }
}
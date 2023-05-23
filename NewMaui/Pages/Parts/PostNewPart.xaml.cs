namespace NewMaui.Pages.Parts;
using NewMaui.Model;
using NewMaui.Data;

public partial class PostNewPart : ContentPage
{
    public PostNewPart()
	{
		InitializeComponent();
	}
    private async void OnLabelClickedSave(object sender, EventArgs e)
    {
        var newPart = new Part
        {
            PartName = partNameEntry.Text,
            NumberInStock = int.Parse(numberInStockEntry.Text),
            PartPrice = (double) decimal.Parse(partPriceEntry.Text)
        };

        var partsData = new PartsData();
        await partsData.AddPartAsync(newPart);

        // Navigate back to the previous page
        await Navigation.PopAsync();
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        var homeToolbarItem = new ToolbarItem
        {
            Text = "Home",
            IconImageSource = "home_icon.png",
            Priority = 0,
            Order = ToolbarItemOrder.Primary
        };
        homeToolbarItem.Clicked += GoToHomePage;

        ToolbarItems.Add(homeToolbarItem);
    }
    private async void GoToHomePage(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
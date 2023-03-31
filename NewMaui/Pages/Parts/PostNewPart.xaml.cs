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
        var newPart = new tblParts
        {
            partName = partNameEntry.Text,
            numberInStock = int.Parse(numberInStockEntry.Text),
            partPrice = (double) decimal.Parse(partPriceEntry.Text)
        };

        var partsData = new PartsData();
        await partsData.AddPartAsync(newPart);

        // Navigate back to the previous page
        await Navigation.PopAsync();
    }
}
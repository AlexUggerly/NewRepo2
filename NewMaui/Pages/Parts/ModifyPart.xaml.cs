namespace NewMaui.Pages.Parts;
using NewMaui.Data;
using NewMaui.Model;

public partial class ModifyPart : ContentPage
{
    private PartsData _partsData;
    public ModifyPart()
	{
		InitializeComponent();
        _partsData = new PartsData();
    }
    private async void OnLabelClickedModify(object sender, EventArgs e)
    {
        // Get the updated part information from the form
        int PartID = int.Parse(partIDEntry.Text);
        string PartName = partNameEntry.Text;
        int NumberInStock = int.Parse(numberInStockEntry.Text);
        double PartPrice = (double)decimal.Parse(partPriceEntry.Text);

        // Create a new Part object with the updated information
        Part updatedPart = new Part
        {
            PartID = PartID,
            PartName = PartName,
            NumberInStock = NumberInStock,
            PartPrice = PartPrice
        };

        // Call the ModifyPartAsync method on the PartsData instance to update the part
        await _partsData.ModifyPartAsync(PartID, updatedPart);

        // Display a message to the user indicating the part has been updated
        await DisplayAlert("Part Updated", $"Part with ID {PartID} has been updated.", "OK");

        // Navigate back to the previous page
        await Navigation.PopAsync();
    }

}

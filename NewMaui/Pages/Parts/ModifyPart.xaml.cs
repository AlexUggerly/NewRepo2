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
        int partID = int.Parse(partIDEntry.Text);
        string partName = partNameEntry.Text;
        int numberInStock = int.Parse(numberInStockEntry.Text);
        double partPrice = (double)decimal.Parse(partPriceEntry.Text);

        // Create a new tblParts object with the updated information
        tblParts updatedPart = new tblParts
        {
            partName = partName,
            numberInStock = numberInStock,
            partPrice = partPrice
        };

        // Call the ModifyPartAsync method on the PartsData instance to update the part
        await _partsData.ModifyPartAsync(partID, updatedPart);

        // Display a message to the user indicating the part has been updated
        await DisplayAlert("Part Updated", $"Part with ID {partID} has been updated.", "OK");

        // Navigate back to the previous page
        await Navigation.PopAsync();
    }
}

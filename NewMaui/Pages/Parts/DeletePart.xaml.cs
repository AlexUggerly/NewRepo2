namespace NewMaui.Pages.Parts;
using NewMaui.Data;

public partial class DeletePart : ContentPage
{
    private PartsData _partsData = new PartsData();
    public DeletePart()
	{
		InitializeComponent();
	}
    private async void OnLabelClickedDelete(object sender, EventArgs e)
    {
        // Get the entered part ID
        int partID = int.Parse(partIDEntry.Text);

        // Delete the part with the entered ID
        await _partsData.DeletePartAsync(partID);

        // Display a message to the user indicating the part has been deleted
        await DisplayAlert("Part Deleted", $"Part with ID {partID} has been deleted.", "OK");

        // Navigate back to the previous page
        await Navigation.PopAsync();
    }

}
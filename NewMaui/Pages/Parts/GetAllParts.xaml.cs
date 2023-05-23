using NewMaui.Data;
using NewMaui.Model;

namespace NewMaui.Pages;

public partial class GetAllParts : ContentPage
{
    public List<Part> parts { get; set; }
    public GetAllParts()
{
    InitializeComponent();
    parts = new List<Part>(); // Initialize parts list
    BindingContext = this;
    LoadDataAsync();
}
    public async Task LoadDataAsync()
    {
        PartsData partsData = new PartsData();
        parts = await partsData.GetPartsAsync();
        OnPropertyChanged(nameof(parts));
    }

}
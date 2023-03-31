using NewMaui.Data;
using NewMaui.Model;

namespace NewMaui.Pages;

public partial class GetAllParts : ContentPage
{
    public List<tblParts> parts { get; set; }
    public GetAllParts()
	{
		InitializeComponent();		
		PartsData partsData = new PartsData();
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
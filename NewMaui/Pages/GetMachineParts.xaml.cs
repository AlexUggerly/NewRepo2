using NewMaui.Data;
using NewMaui.Model;

namespace NewMaui.Pages;

public partial class GetMachineParts : ContentPage
{
    public List<tblMachineParts> machineParts { get; set; }
    public GetMachineParts()
    {
        InitializeComponent();
        MachineParts machinePartsData = new MachineParts();
        BindingContext = this;
        LoadDataAsync();
    }
    public async Task LoadDataAsync()
    {
        MachineParts machinePartsData = new MachineParts();
        machineParts = await machinePartsData.GetMachinePartsAsync();
        OnPropertyChanged(nameof(machineParts));
    }
}
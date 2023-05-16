namespace NewMaui.Pages.Service.PostService;
using NewMaui.Data;
using NewMaui.Model;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

public partial class Post2 : ContentPage, INotifyPropertyChanged
{
    private List<Part> _parts;
    public List<Part> Parts
    {
        get { return _parts; }
        set
        {
            _parts = value;
            OnPropertyChanged(nameof(Parts));
        }
    }
    public Post2()
	{
		InitializeComponent();
        PartsData partsData = new PartsData();
        BindingContext = this;    
        LoadServicePartsAsync();
	}
    public async Task LoadServicePartsAsync()
    {
        PartsData partsData = new PartsData();
        Parts = await partsData.GetPartsAsync();
    }
    private async void OnButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Post2());
    }
}
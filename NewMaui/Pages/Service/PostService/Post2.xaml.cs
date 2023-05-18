using NewMaui.Data;
using NewMaui.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace NewMaui.Pages.Service.PostService
{
    public partial class Post2 : ContentPage
    {
        private ObservableCollection<Part> selectedParts = new ObservableCollection<Part>();
        private PartsData partsData = new PartsData();

        public ObservableCollection<Part> SelectedParts
        {
            get { return selectedParts; }
            set
            {
                selectedParts = value;
                OnPropertyChanged(nameof(SelectedParts));
            }
        }
        public Post2()
        {
            InitializeComponent();
            LoadServicePartsAsync();
        }

        public async Task LoadServicePartsAsync()
        {
            var parts = await partsData.GetPartsAsync();
            foreach (var part in parts)
            {
                var picker = new Picker
                {
                    ItemsSource = parts,
                    ItemDisplayBinding = new Binding("PartName"),
                    Title = "Reservedel:",
                    FontSize = 30,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontAttributes = FontAttributes.Bold,
                    HeightRequest = 80
                };
                picker.SelectedIndexChanged += OnPickerSelectedIndexChanged;
                PickerStackLayout.Children.Add(picker);
            }
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedPart = (Part)picker.SelectedItem;
            if (selectedPart != null)
            {
                SelectedParts.Add(selectedPart);
            }
        }
        private void OnClearSelectionClicked(object sender, EventArgs e)
        {
            foreach (var picker in PickerStackLayout.Children.OfType<Picker>())
            {
                picker.SelectedItem = null;
            }
        }
        private void OnAddPartClicked(object sender, EventArgs e)
        {
            foreach (var picker in PickerStackLayout.Children.OfType<Picker>())
            {
                var selectedPart = (Part)picker.SelectedItem;
                if (selectedPart != null)
                {
                    SelectedParts.Add(selectedPart);
                    picker.SelectedItem = null; // Reset the selected item
                }
            }
        }

        private async void OnButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Post3());
        }
    }
}

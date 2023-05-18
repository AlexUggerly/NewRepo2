namespace NewMaui.Pages.Service.PostService;
using NewMaui;
using System.Net.Http.Headers;
using System.Text;


public partial class Post3 : ContentPage
{
    public string SelectedMachine { get; set; } // Add this property
    public DateTime SelectedDate { get; set; }
    public int CustomerID { get; set; }
    public Post3()
    {
        InitializeComponent();
    }
    /*    private async void OnButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(kmEntry.Text))
            {
                await DisplayAlert("Error", "Indtast km", "OK");
                return;
            }
            if (string.IsNullOrEmpty(transportTimeEntry.Text))
            {
                await DisplayAlert("Error", "Indtast transporttid", "OK");
                return;
            }
            if (string.IsNullOrEmpty(workTimeEntry.Text))
            {
                await DisplayAlert("Error", "Indtast arbejdstid", "OK");
                return;
            }
            if (string.IsNullOrEmpty(statusEntry.Text))
            {
                await DisplayAlert("Error", "Indtast Status", "OK");
                return;
            }
            await Navigation.PushAsync(new Service());
        }*/
    private async void PostButton_Clicked(object sender, EventArgs e)
    {

        var serviceDate = SelectedDate.Date;
        var customerID = CustomerID.Text;
        var machineID = MachineIDEntry.Text;
        var machineSerialNumber = SelectedMachine;
        var partsUsed = .Text;
        var transportTimeUsed = transportTimeEntry.Text;
        var transportKmUsed = kmEntry.Text;
        var workTimeUsed = workTimeEntry.Text;
        var note = noteEntry.Text;
        var machineStatus = statusEntry.Text;

        // Create the object with the collected data
        var service = new Service
        {

            ServiceDate = serviceDate,
            CustomerID = customerID,
            MachineID = machineID,
            MachineSerialNumber = machineSerialNumber,
            PartsUsed = partsUsed,
            TransportTimeUsed = transportTimeUsed,
            TransportKmUsed = transportKmUsed,
            WorkTimeUsed = workTimeUsed,
            Note = note,
            MachineStatus = machineStatus
        };

        // Serialize the object to JSON
        var json = JsonConvert.SerializeObject(service);

        // Create the HTTP client
        var httpClient = new HttpClient();

        // Set the content type header
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // Send the POST request to the API endpoint
        var response = await httpClient.PostAsync("http://your-api-endpoint-url", new StringContent(json, Encoding.UTF8, "application/json"));

        if (response.IsSuccessStatusCode)
        {
            // Successful POST request
            MessageBox.Show("Service data posted successfully.");
        }
        else
        {
            // Failed POST request
            MessageBox.Show("Failed to post service data. Error: " + response.StatusCode);
        }
    }
}
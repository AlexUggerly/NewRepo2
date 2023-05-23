using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using NewMaui.Model;


namespace NewMaui.Data
{
    public class ServiceData
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public ServiceData()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions();
        }
        public async Task<List<GetService>> GetServicesAsync()
        {
            List<GetService> services = new();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10); // Set a timeout of 10 seconds
                    services = await client.GetFromJsonAsync<List<GetService>>("https://www.shiggy.dk/api/services");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return services;
        }
        public async Task PostServiceDataAsync(int customerId, int machineId, string machineSerialNumber, List<Part> serviceParts, int transportTimeUsed, int transportKmUsed, int workTimeUsed, string note, string machineStatus)
        {
            // Create the data object
            var data = new
            {
                customerID = customerId,
                machineID = machineId,
                machineSerialNumber = machineSerialNumber,
                serviceParts = serviceParts,
                transportTimeUsed = transportTimeUsed,
                transportKmUsed = transportKmUsed,
                workTimeUsed = workTimeUsed,
                note = note,
                machineStatus = machineStatus
            };

  
            var json = JsonSerializer.Serialize(data);

            // Send the data to the API endpoint
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("https://www.shiggy.dk/api/services/createnewservice", content);

            // Check the response status
            if (response.IsSuccessStatusCode)
            {
                // Data sent successfully
                Console.WriteLine("Service data sent successfully");
            }
            else
            {
                // Error occurred
                Console.WriteLine("Error sending service data: " + response.StatusCode);
            }
        }
        
    }
}


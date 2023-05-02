using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
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
    }
}

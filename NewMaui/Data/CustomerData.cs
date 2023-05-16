using NewMaui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewMaui.Data
{
    public class CustomerData
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public CustomerData()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions();
        }
        public async Task<List<GetCustomers>> GetCustomersAsync()
        {
            List<GetCustomers> customers = new();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10); // Set a timeout of 10 seconds
                    customers = await client.GetFromJsonAsync<List<GetCustomers>>("https://www.shiggy.dk/api/customers");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return customers;

        }       


    }
}
   

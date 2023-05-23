using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewMaui.Model;
using System.Text.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;



namespace NewMaui.Data
{
    public class InvoiceData
    {
        public async Task<List<Invoice>> GetInvoiceDataAsync(int serviceID)
        {
            List<Invoice> invoiceData = new List<Invoice>();

            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10); // Set a timeout of 10 seconds

                    string url = $"https://www.shiggy.dk/api/services/CalculateInvoice/{serviceID}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        invoiceData = JsonSerializer.Deserialize<List<Invoice>>(responseContent);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return invoiceData;
        }

    }
}

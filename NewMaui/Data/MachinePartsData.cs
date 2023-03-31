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
    public class MachineParts
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public MachineParts()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions();
        }
        public async Task<List<tblMachineParts>> GetMachinePartsAsync()
        {
            List<tblMachineParts> parts = new();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10); // Set a timeout of 10 seconds
                    parts = await client.GetFromJsonAsync<List<tblMachineParts>>("https://www.shiggy.dk/api/MachineParts");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            return parts;
        }

    }
}

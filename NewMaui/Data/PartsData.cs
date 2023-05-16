using NewMaui.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

namespace NewMaui.Data
{
    public class PartsData
    {
        public List<Part> AvailableParts { get; private set; }
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;
        public PartsData()
        {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions();
        }
        public async Task<List<Part>> GetPartsAsync()
        {
            List<Part> parts = new();
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10); // Set a timeout of 10 seconds
                    parts = await client.GetFromJsonAsync<List<Part>>("https://www.shiggy.dk/api/parts");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return parts;
        }
        public async Task<List<Part>> GetServicePartsAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.Timeout = TimeSpan.FromSeconds(10); // Set a timeout of 10 seconds
                    AvailableParts = await client.GetFromJsonAsync<List<Part>>("https://www.shiggy.dk/api/parts");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return AvailableParts;
        }
        public async Task AddPartAsync(Part part)
        {
            try
            {
                var json = JsonSerializer.Serialize(new
                {
                    partName = part.PartName,
                    numberInStock = part.NumberInStock,
                    partPrice = part.PartPrice
                }, _serializerOptions);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("https://www.shiggy.dk/api/parts", content);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        public async Task DeletePartAsync(int id)
        {
            try
            {
                var response = await _client.DeleteAsync($"https://www.shiggy.dk/api/parts/{id}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        public async Task ModifyPartAsync(int id, Part updatedPart)
        {
            try
            {
                var json = JsonSerializer.Serialize(new
                {
                    partName = updatedPart.PartName,
                    numberInStock = updatedPart.NumberInStock,
                    partPrice = updatedPart.PartPrice
                }, _serializerOptions);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _client.PutAsync($"https://www.shiggy.dk/api/parts/{id}", content);               
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}


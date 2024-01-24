using Domain;
using Domain.Entity;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Infraestructure.DataSource
{
    public class Register
    {
        public int id { get; set; }
        public string title { get; set; }
    }

    public class ProductDataSource
    {
        private readonly HttpClient httpClient;

        public ProductDataSource() { 
            this.httpClient = new HttpClient();
        }
        public async Task<Product> GetProduct(int id)
        {
            HttpResponseMessage response =  await this.httpClient.GetAsync($"https://dummyjson.com/products/{id}", HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            Product? apiRes = await response.Content.ReadFromJsonAsync<Product>();

            return apiRes is null ? throw new Exception("No se encontró el producto especificado") : apiRes;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            HttpResponseMessage response = await this.httpClient.GetAsync("https://dummyjson.com/products/", HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            PaginationProducts? apiRes = await response.Content.ReadFromJsonAsync<PaginationProducts>();

            return apiRes?.products == null ? throw new Exception("No se encontró el producto especificado") : apiRes.products;
        }

        public async Task<Register> RegisterProduct(string title)
        {
            string apiUrl = "https://dummyjson.com/products/add";

            var producto = new
            {
                title = title,
            };
            string jsonProducto = JsonSerializer.Serialize(producto);
            StringContent httpContent = new StringContent(jsonProducto, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await this.httpClient.PostAsync(apiUrl, httpContent);
            response.EnsureSuccessStatusCode();

            // Leer el contenido de la respuesta
            string resultJson = await response.Content.ReadAsStringAsync();
            Register result = JsonSerializer.Deserialize<Register>(resultJson) ?? throw new Exception("No se pudo registrar el producto");
            return result;
        }

    }
}

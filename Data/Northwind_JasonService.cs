using System.Net.Http.Json;

namespace ComponentTestbed.Northwind_Jason
{
    public class Northwind_JasonService
    {
        private readonly HttpClient http;

        public Northwind_JasonService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<ApiCustomersType[]?> GetApiCustomers()
        {
            return await this.http.GetFromJsonAsync<ApiCustomersType[]?>("https://northwindcloud.azurewebsites.net/api/customers");
        }
    }
}
using System.Net.Http.Json;

namespace BlazorTest.Northwind
{
    public class NorthwindService
    {
        private readonly HttpClient http;

        public NorthwindService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<EmployeesType[]?> GetEmployees()
        {
            return await http.GetFromJsonAsync<EmployeesType[]?>("static-data/northwind-employees.json");
        }

        public async Task<CustomersType[]?> GetCustomers()
        {
            return await http.GetFromJsonAsync<CustomersType[]?>("static-data/northwind-customers.json");
        }
    }
}
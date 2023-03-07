using System.Net.Http.Json;

namespace Component_test_app_scenarios.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<CustomersType>?> GetCustomers()
        {
            return await this._http.GetFromJsonAsync<List<CustomersType>>("/static-data/northwind-customers.json");
        }

        public async Task<List<EmployeesType>?> GetEmployees()
        {
            return await this._http.GetFromJsonAsync<List<EmployeesType>>("/static-data/northwind-employees.json");
        }
    }
}
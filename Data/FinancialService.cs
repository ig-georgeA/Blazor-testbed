using System.Net.Http.Json;

namespace BlazorTest.Financial
{
    public class FinancialService
    {
        private readonly HttpClient http;

        public FinancialService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<BoxOfficeRevenueType[]?> GetBoxOfficeRevenue()
        {
            return await http.GetFromJsonAsync<BoxOfficeRevenueType[]?>("static-data/financial-box-office-revenue.json");
        }

        public async Task<GlobalElectricityDemandType[]?> GetGlobalElectricityDemand()
        {
            return await http.GetFromJsonAsync<GlobalElectricityDemandType[]?>("static-data/financial-global-electricity-demand.json");
        }
    }
}
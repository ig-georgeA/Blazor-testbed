using System.Net.Http.Json;

namespace Component_test_app_scenarios.Financial
{
    public class FinancialService: IFinancialService
    {
        private readonly HttpClient _http;

        public FinancialService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<SalesType>?> GetSales()
        {
            return await this._http.GetFromJsonAsync<List<SalesType>>("/static-data/financial-sales.json");
        }

        public async Task<List<BoxOfficeRevenueType>?> GetBoxOfficeRevenue()
        {
            return await this._http.GetFromJsonAsync<List<BoxOfficeRevenueType>>("/static-data/financial-box-office-revenue.json");
        }

        public async Task<List<TradingType>?> GetTrading()
        {
            return await this._http.GetFromJsonAsync<List<TradingType>>("/static-data/financial-trading.json");
        }

        public async Task<List<GlobalElectricityDemandType>?> GetGlobalElectricityDemand()
        {
            return await this._http.GetFromJsonAsync<List<GlobalElectricityDemandType>>("/static-data/financial-global-electricity-demand.json");
        }
    }
}
using System.Text.Json;

namespace Component_test_app_scenarios.Financial
{
    public class FinancialService: IFinancialService
    {
        private readonly IWebHostEnvironment _env;

        public FinancialService(IWebHostEnvironment env)
        {
            this._env = env;
        }

        public async Task<List<SalesType>?> GetSales()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(this._env.WebRootPath + "/static-data/financial-sales.json");
            return await Task.FromResult(JsonSerializer.Deserialize<List<SalesType>>(data, options));
        }

        public async Task<List<BoxOfficeRevenueType>?> GetBoxOfficeRevenue()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(this._env.WebRootPath + "/static-data/financial-box-office-revenue.json");
            return await Task.FromResult(JsonSerializer.Deserialize<List<BoxOfficeRevenueType>>(data, options));
        }

        public async Task<List<TradingType>?> GetTrading()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(this._env.WebRootPath + "/static-data/financial-trading.json");
            return await Task.FromResult(JsonSerializer.Deserialize<List<TradingType>>(data, options));
        }

        public async Task<List<GlobalElectricityDemandType>?> GetGlobalElectricityDemand()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(this._env.WebRootPath + "/static-data/financial-global-electricity-demand.json");
            return await Task.FromResult(JsonSerializer.Deserialize<List<GlobalElectricityDemandType>>(data, options));
        }
    }
}
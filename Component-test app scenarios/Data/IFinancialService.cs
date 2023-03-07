namespace Component_test_app_scenarios.Financial
{
    public interface IFinancialService
    {
        Task<List<SalesType>?> GetSales();

        Task<List<BoxOfficeRevenueType>?> GetBoxOfficeRevenue();

        Task<List<TradingType>?> GetTrading();

        Task<List<GlobalElectricityDemandType>?> GetGlobalElectricityDemand();
    }
}
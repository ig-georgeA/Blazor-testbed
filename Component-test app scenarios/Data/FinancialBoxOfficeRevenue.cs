//namespace Component_test_app_scenarios.Data.Financial; // Razor won't recognize third level namespace
namespace Component_test_app_scenarios.Financial;

public class BoxOfficeRevenueType
{
    public string? Franchise { get; set; }
    public double TotalWorldBoxOfficeRevenue { get; set; }
    public double HighestGrossingMovieInSeries { get; set; }
}

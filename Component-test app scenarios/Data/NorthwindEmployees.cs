//namespace Component_test_app_scenarios.Data.Northwind; // Razor won't recognize third level namespace
namespace Component_test_app_scenarios.Northwind;

public class EmployeesType
{
    public double EmployeeID { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Title { get; set; }
    public string? TitleOfCourtesy { get; set; }
    public DateTime? BirthDate { get; set; }
    public DateTime? HireDate { get; set; }
    public double ManagerID { get; set; }
    public string? Notes { get; set; }
    public string? AvatarUrl { get; set; }
    public AddressType? Address { get; set; }
}

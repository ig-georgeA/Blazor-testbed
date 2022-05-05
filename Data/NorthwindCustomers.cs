//namespace TestingComponentsDontDelete.Data.Northwind; // Razor won't recognize third level namespace
namespace TestingComponentsDontDelete.Northwind;

public class CustomersType
{
    public string? CustomerID { get; set; }
    public string? CompanyName { get; set; }
    public string? ContactName { get; set; }
    public string? ContactTitle { get; set; }
    public Address? Address { get; set; }
}

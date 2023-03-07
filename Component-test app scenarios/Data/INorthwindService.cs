namespace Component_test_app_scenarios.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>?> GetCustomers();

        Task<List<EmployeesType>?> GetEmployees();
    }
}
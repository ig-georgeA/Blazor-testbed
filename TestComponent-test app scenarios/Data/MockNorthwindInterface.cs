namespace Component_test_app_scenarios.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<CustomersType>?> GetCustomers()
        {
            return Task.FromResult<List<CustomersType>?>(new());
        }

        public Task<List<EmployeesType>?> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>?>(new());
        }
    }
}
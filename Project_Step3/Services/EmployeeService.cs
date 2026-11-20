using Project_Step3.Models;

namespace Project_Step3.Services
{
    public class EmployeeService
    {
        public List<EmployeeModels> GetEmployees()
        {
            return new List<EmployeeModels>
            {
                new EmployeeModels { Id = 1, Name = "John"},
                new EmployeeModels {Id = 2, Name = "Michel"}
            };
        }
    }
}

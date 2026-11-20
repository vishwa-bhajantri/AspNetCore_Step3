using Project_Step3.Models;
using Project_Step3.Interfaces;

namespace Project_Step3.Services
{
    public class EmployeeService : IEmployeeService
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

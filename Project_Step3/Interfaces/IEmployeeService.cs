using Project_Step3.Models;

namespace Project_Step3.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeModels> GetEmployees();

        EmployeeModels GetEmployeeById(int id);

        EmployeeModels CreateEmployee(EmployeeModels employee);

        EmployeeModels UpdateEmployee(int id, EmployeeModels employee);

        bool DeleteEmployee(int id);
    }
}

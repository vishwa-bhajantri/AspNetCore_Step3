using Microsoft.AspNetCore.Mvc;
using Project_Step3.Interfaces;
using Project_Step3.Models;

namespace Project_Step3.Services
{
    public class EmployeeService : IEmployeeService
    {

        public EmployeeService()
        {

        }

        private readonly List<EmployeeModels> _employees = new()
        {
                new EmployeeModels { Id = 1, Name = "John"},
                new EmployeeModels { Id = 2, Name = "Michel"}
        };
        public List<EmployeeModels> GetEmployees()
        {
            return _employees;
        }

        public EmployeeModels GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(x => x.Id == id);
        }

        public EmployeeModels CreateEmployee(EmployeeModels employee)
        {
            employee.Id = _employees.Count == 0 ? 1 : _employees.Max(x => x.Id) + 1;

            //if(employee.Id == 0)
            //{
            //    employee.Id = 1;
            //}
            //else
            //{
            //    employee.Id = employees.Max(x => x.Id) + 1;
            //}

            _employees.Add(employee);
            return employee;
        }

        public EmployeeModels UpdateEmployee(int id, EmployeeModels employee)
        {
            EmployeeModels? existingEmployee = _employees.FirstOrDefault(x => x.Id == id);
            if (existingEmployee == null)
            {
                return null;
            }
            existingEmployee.Name = employee.Name;
            return existingEmployee;
        }

        public bool DeleteEmployee(int id)
        {
            EmployeeModels? existingEmployee = _employees.FirstOrDefault(x => x.Id == id);
            if (existingEmployee == null)
            {
                return false;
            }
            _employees.Remove(existingEmployee);
            return true;
        }

        

        
    }
}

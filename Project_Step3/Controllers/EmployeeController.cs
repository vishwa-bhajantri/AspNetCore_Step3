using Microsoft.AspNetCore.Mvc;
using Project_Step3.Models;
using Project_Step3.Services;
using Project_Step3.Interfaces;

namespace Project_Step3.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            IEmployeeService employeeService = new EmployeeService();

            List<EmployeeModels> Data = employeeService.GetEmployees().ToList();

            return Ok(Data);

            //var Data = employeeService.GetEmployees();
        }

        [HttpGet("GetEmployeeById/{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            IEmployeeService employeeService = new EmployeeService();

            var Data = employeeService.GetEmployeeById(id);

            if (Data == null)
                return NotFound();

            return Ok(Data);
        }

        [HttpPost("CreateEmployee")]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeModels employee)
        {
            IEmployeeService employeeService = new EmployeeService();

            var Data = employeeService.CreateEmployee(employee);

            return Ok(Data);
        }

        [HttpPut("UpdateEmployee/{id}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] int id, [FromBody] EmployeeModels employee)
        {
            IEmployeeService employeeService = new EmployeeService();

            var Data = employeeService.UpdateEmployee(id,employee);

            if (Data == null)
                return NotFound();

            return Ok(Data);
        }

        [HttpPut("DeleteEmployee/{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] int id)
        {
            IEmployeeService employeeService = new EmployeeService();

            bool Data = employeeService.DeleteEmployee(id);

            if (!Data)
                return NotFound();

            return NoContent();
        }
    }
}

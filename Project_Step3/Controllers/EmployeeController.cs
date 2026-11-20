using Microsoft.AspNetCore.Mvc;
using Project_Step3.Models;
using Project_Step3.Services;

namespace Project_Step3.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            List<EmployeeModels> Data = employeeService.GetEmployees().ToList();
            return Ok(Data);

            //var Data = employeeService.GetEmployees();

        }
    }
}

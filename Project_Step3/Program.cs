using Project_Step3.Interfaces;
using Project_Step3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddTransient<IEmployeeService, EmployeeService>();    // now asp.net core taking responsibility to create the instance of the EmployeeService

var app = builder.Build();;

app.MapControllers();

app.Run();

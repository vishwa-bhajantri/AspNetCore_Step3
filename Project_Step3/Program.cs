
using Microsoft.AspNetCore.SignalR;
using Project_Step3.Interfaces;
using Project_Step3.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddSingleton<ISingletonCoffee, CoffeeShopService>();

builder.Services.AddScoped<IScopedCoffee, CoffeeShopService>();

builder.Services.AddTransient<ITransientCoffee, CoffeeShopService>();

var app = builder.Build();;

app.MapControllers();

app.Run();

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using MovieMnagementLibrary.Data;
using MovieMnagementLibrary.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IDataRepository, DataRepository>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(IDataRepository).Assembly));
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Weather.Infrastructure.Contexts;
using Weather.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<WeatherContext>(options =>
  options.UseNpgsql(builder.Configuration.GetConnectionString("WeatherContext"))
    .UseSnakeCaseNamingConvention()
  );
  
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<WeatherContext>();
    context.Database.EnsureCreated();
    WeatherSeeder.Initialize(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.MapOpenApi();
}

app.UseHttpsRedirection();

// var summaries = new[]
// {
//     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
// };

app.MapGet("/weatherforecast", () =>
{
    
})
.WithName("GetWeatherForecast");

app.Run();
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Weather.Application.Interfaces.Repositories;
using Weather.Application.Interfaces.Services;
using Weather.Application.Services;
using Weather.Infrastructure.Contexts;
using Weather.Infrastructure.Repositories;
using Weather.Infrastructure.Seeders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IWeatherForecastService, WeatherForecastService>();
builder.Services.AddScoped<IWeatherForecastRepository, WeatherForecastRepository>();

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

app.MapGet("/weatherforecast", (IWeatherForecastService weatherForecastService) =>
{
  return weatherForecastService.GetWeatherForecastsByStationId(1, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now.AddDays(5)));
})
.WithName("GetWeatherForecast");

app.Run();
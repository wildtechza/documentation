using Weather.Infrastructure.Models;
using Weather.Infrastructure.Contexts;

namespace Weather.Infrastructure.Seeders;

public static class WeatherSeeder
{
    public static void Initialize(WeatherContext context)
    {
        // Populate stations if needed.
        if (!context.Set<StationData>().Any())
        {
            var stations = new StationData[]
            {
                new() { Id = 1, Name = "Station A" },
                new() { Id = 2, Name = "Station B" },
                new() { Id = 3, Name = "Station C" },
                new() { Id = 4, Name = "Station D" }
            };

            context.Stations.AddRange(stations);
            context.SaveChanges();
        }

        // Look for any students.
        if (context.WeatherForecasts.Any())
        {
            return;   // DB has been seeded
        }

        var stationIds = new[] { 1, 2, 3, 4 };
        var summaries = new[] { "Warm", "Cool", "Chilly", "Freezing", "Mild" };
        var random = new Random();
        var weatherForecasts = new List<WeatherForecastData>();
        for (int day = 0; day < 5; day++)
        {
            foreach (var stationId in stationIds)
            {
                int minTemp = random.Next(-5, 20);
                int maxTemp = minTemp + random.Next(3, 8);
                weatherForecasts.Add(new WeatherForecastData
                {
                    StationId = stationId,
                    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(day + 1)),
                    MinimumTemperatureC = minTemp,
                    MaximumTemperatureC = maxTemp,
                    Summary = summaries[day % summaries.Length]
                });
            }
        }

        context.WeatherForecasts.AddRange(weatherForecasts);
        context.SaveChanges();
    }
}

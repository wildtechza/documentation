namespace Weather.Infrastructure.Models;

public class WeatherForecastData
{
    public int StationId { get; set; }
    public DateOnly Date { get; set; }
    public int MinimumTemperatureC { get; set; }
    public int MaximumTemperatureC { get; set; }
    public string? Summary { get; set; }
}
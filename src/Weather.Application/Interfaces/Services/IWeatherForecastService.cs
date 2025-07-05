using Weather.Core.Models;

namespace Weather.Application.Interfaces.Services;

public interface IWeatherForecastService
{
    IEnumerable<WeatherForecast> GetWeatherForecastsByStationId(int stationId, DateOnly startDate, DateOnly endDate);
}
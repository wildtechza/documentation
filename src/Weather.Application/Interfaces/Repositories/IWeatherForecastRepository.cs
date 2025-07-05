using Weather.Core.Models;

namespace Weather.Application.Interfaces.Repositories;

public interface IWeatherForecastRepository
{
    IEnumerable<WeatherForecast> GetWeatherForecastsByStationId(int stationId, DateOnly startDate, DateOnly endDate);
}

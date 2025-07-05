using Weather.Application.Interfaces.Repositories;
using Weather.Core.Models;
using Weather.Infrastructure.Contexts;

namespace Weather.Infrastructure.Repositories;

public class WeatherForecastRepository(WeatherContext weatherContext) : IWeatherForecastRepository
{
    public IEnumerable<WeatherForecast> GetWeatherForecastsByStationId(int stationId, DateOnly startDate, DateOnly endDate) =>
        weatherContext.WeatherForecasts
            .Where(wf => wf.StationId == stationId && wf.Date >= startDate && wf.Date <= endDate)
            .Select(wf => new WeatherForecast(wf.Date, (wf.MinimumTemperatureC + wf.MaximumTemperatureC) / 2, wf.Summary));
}

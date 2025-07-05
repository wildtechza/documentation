using System;
using Weather.Application.Interfaces;
using Weather.Application.Interfaces.Repositories;
using Weather.Application.Interfaces.Services;
using Weather.Core.Models;

namespace Weather.Application.Services;

public class WeatherForecastService(IWeatherForecastRepository weatherForecastRepository) : IWeatherForecastService
{
    public IEnumerable<WeatherForecast> GetWeatherForecastsByStationId(int stationId, DateOnly startDate, DateOnly endDate) =>
        weatherForecastRepository.GetWeatherForecastsByStationId(stationId, startDate, endDate);
}
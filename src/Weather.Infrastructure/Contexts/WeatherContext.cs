using Microsoft.EntityFrameworkCore;
using Weather.Infrastructure.Models;

namespace Weather.Infrastructure.Contexts;

public class WeatherContext(DbContextOptions<WeatherContext> options) : DbContext(options)
{
    public DbSet<StationData> Stations { get; set; }

    public DbSet<WeatherForecastData> WeatherForecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StationData>()
            .HasKey(w => new { w.Id });

        modelBuilder.Entity<WeatherForecastData>()
            .HasKey(w => new { w.StationId, w.Date });
    }
}
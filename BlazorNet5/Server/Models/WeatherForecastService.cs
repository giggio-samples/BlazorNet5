using BlazorNet5.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNet5.Server.Models
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private static readonly Random rng = new Random();
        private static readonly IList<WeatherForecast> forecasts = Enumerable.Range(1, 10_000).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        }).ToList();
        public Task<WeatherForecastResult> GetWeatherForecastAsync(int? startIndex, int? count) =>
            Task.FromResult(new WeatherForecastResult(forecasts.Skip(startIndex ?? 0).Take(count ?? 100), forecasts.Count));
    }
}

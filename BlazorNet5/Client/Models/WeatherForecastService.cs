using BlazorNet5.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNet5.Client.Models
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient client;

        public WeatherForecastService(HttpClient client) => this.client = client;

        public async Task<WeatherForecastResult> GetWeatherForecastAsync(int? startIndex, int? count)
        {
            var forecastsResult = await client.GetFromJsonAsync<WeatherForecastResult>($"WeatherForecast?startIndex={startIndex}&count={count}");
            return forecastsResult;
        }
    }
}

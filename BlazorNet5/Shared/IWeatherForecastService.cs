using System.Threading.Tasks;

namespace BlazorNet5.Shared
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecastResult> GetWeatherForecastAsync(int? startIndex, int? count);
    }
}

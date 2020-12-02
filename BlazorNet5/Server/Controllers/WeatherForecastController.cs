using BlazorNet5.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlazorNet5.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService) =>
            this.weatherForecastService = weatherForecastService;

        [HttpGet]
        public Task<WeatherForecastResult> Get(int? startIndex, int? count) =>
            weatherForecastService.GetWeatherForecastAsync(startIndex, count);
    }
}

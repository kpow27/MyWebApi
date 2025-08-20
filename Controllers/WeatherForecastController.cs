using Microsoft.AspNetCore.Mvc;
using MyWebApi;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherForecastController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }


    [HttpGet]
    public IEnumerable<string> Get()
    {
        return _weatherService.GetForecast();
        //return new[] { "Sunny", "Cloudy", "Rainy", "Dreich" };
    }
}

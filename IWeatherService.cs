namespace MyWebApi
{
    public interface IWeatherService
    {
        IEnumerable<string> GetForecast();
    }
}

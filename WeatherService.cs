namespace MyWebApi
{
    public class WeatherService : IWeatherService
    {
        public IEnumerable<string> GetForecast()
        {
            return new[] { "Sunny", "Cloudy", "Rainy" };
        }

    }
}

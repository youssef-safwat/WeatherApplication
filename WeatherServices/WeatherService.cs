using WeatherModels;
using WeatherServiceContracts;

namespace WeatherServices
{
    public class WeatherService : IWeatherService
    {
        private readonly List<CityWeather> _citiesWeather;
        public WeatherService()
        {
            _citiesWeather =
            [
                new CityWeather
                {
                    CityUniqueCode = "LDN",
                    CityName = "London",
                    DateAndTime = Convert.ToDateTime("2030-01-01 8:00"),
                    TemperatureFahrenheit = 33
                },
                new CityWeather
                {
                    CityUniqueCode = "NYC",
                    CityName = "New York City",
                    DateAndTime = Convert.ToDateTime("2030-01-01 3:00"),
                    TemperatureFahrenheit = 60
                },
                new CityWeather
                {
                    CityUniqueCode = "PAR",
                    CityName = "Paris",
                    DateAndTime = Convert.ToDateTime("2030-01-01 9:00"),
                    TemperatureFahrenheit = 82
                },
                new CityWeather
                {
                    CityUniqueCode = "EGY",
                    CityName = "Egypt",
                    DateAndTime = Convert.ToDateTime("2030-01-01 23:00"),
                    TemperatureFahrenheit = 11
                },
                new CityWeather
                {
                    CityUniqueCode = "CAL",
                    CityName = "California",
                    DateAndTime = Convert.ToDateTime("2030-01-01 23:00"),
                    TemperatureFahrenheit = 100
                }
            ];
        }
        public CityWeather? GetWeatherByCityCode(string cityCode)
        {
            CityWeather? foundedCity = _citiesWeather.FirstOrDefault(x => x.CityUniqueCode == cityCode);
            return foundedCity;
        }

        public List<CityWeather> GetWeatherDetails()
        {
            return _citiesWeather;
        }
    }
}

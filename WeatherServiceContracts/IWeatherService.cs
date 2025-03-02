
using WeatherModels;

namespace WeatherServiceContracts
{
    public interface IWeatherService
    {
        CityWeather? GetWeatherByCityCode(string CityCode);
        public List<CityWeather> GetWeatherDetails();
    }
}

//IWeatherService
//    - List < CityWeather > GetWeatherDetails() - Returns a list of CityWeather objects that contains weather details of cities
//    - CityWeather? GetWeatherByCityCode(string CityCode) - Returns an object of CityWeather based on the given city code

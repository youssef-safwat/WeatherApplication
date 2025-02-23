using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<CityWeather> _cityWeathers =
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
            }
        ];
        [HttpGet]
        [Route("/")]
        [Route("home")]
        public IActionResult Index()
        {
            return View(_cityWeathers);
        }

        [HttpGet]
        [Route("/weather/{cityCode:length(3)}")]
        public IActionResult Details(string cityCode)
        {
            CityWeather? foundedCity = _cityWeathers.FirstOrDefault(x => x.CityUniqueCode == cityCode);
            if(foundedCity is null)
            {
                return View("NotFounded");
            }
            return View(foundedCity);
        }
    }
}

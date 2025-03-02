using Microsoft.AspNetCore.Mvc;
using WeatherServiceContracts;

namespace WeatherApplication.Controllers
{
    public class HomeController(IWeatherService weatherService) : Controller
    {
        private readonly IWeatherService _weatherService = weatherService;

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("forecast")]
        public IActionResult Forecast()
        {
            var citiesWeather = _weatherService.GetWeatherDetails();
            return View(citiesWeather);
        }

        [HttpGet]
        [Route("forecast/{cityCode:length(3)}")]
        public IActionResult Details(string cityCode)
        {
            var foundedCity = _weatherService.GetWeatherByCityCode(cityCode);
            return View(foundedCity);
        }
    }
}

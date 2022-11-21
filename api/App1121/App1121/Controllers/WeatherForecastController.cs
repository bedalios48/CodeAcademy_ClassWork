using App1121.Models;
using Microsoft.AspNetCore.Mvc;

namespace App1121.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IBookSet _books;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IBookSet books)
        {
            _logger = logger;
            _books = books;
        }

        [HttpGet(Name = "GetBooks")]
        public List<Book> Get()
        {
            return _books.Books;
        }
    }
}
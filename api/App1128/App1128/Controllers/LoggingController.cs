using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App1128.Controllers
{
    /// <summary>
    /// Main summary
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class LoggingController : ControllerBase
    {
        private readonly ILogger<LoggingController> _logger;
        private readonly IDivisionService _divisionService;

        public LoggingController(ILogger<LoggingController> logger, IDivisionService divisionService)
        {
            _logger = logger;
            _divisionService = divisionService;
        }

        /// <summary>
        /// Logging example
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<decimal> Get([FromQuery] int firstNumber, int secondNumber)
        {
            _logger.LogInformation("test");
            try
            {
                var result = _divisionService.Divide(firstNumber, secondNumber);
                return Ok(result);
            }
            catch(Exception e)
            {
                _logger.LogError(e, "Exception was thrown");
                return StatusCode(500, 0);
            }
        }
    }
}

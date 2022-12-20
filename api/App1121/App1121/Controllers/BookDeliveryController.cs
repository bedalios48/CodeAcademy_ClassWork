using App1121.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App1121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDeliveryController : ControllerBase
    {
        private readonly IOpenRouteProxyService _openRoute;

        public BookDeliveryController(IOpenRouteProxyService openRoute)
        {
            _openRoute = openRoute;
        }

        /// <summary>
        /// Deliver books to address
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        /// <response code="200">Return successful</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal server error</response>
        [HttpGet("{userId}/Deliver")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeliverBooks(int userId, string city, string country)
        {
            try
            {
                var cityInfo = await _openRoute.GetCityInfo(city);

                return Ok(cityInfo);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}

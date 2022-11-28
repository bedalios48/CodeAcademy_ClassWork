using App1121.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace App1121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<GetBookDto>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ActionResult<GetBookDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> Filter([FromQuery]FilterBookRequest req)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult Post(CreateBookDto req)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Put(UpdateBookDto req)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

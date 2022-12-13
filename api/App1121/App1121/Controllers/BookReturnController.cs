using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App1121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookReturnController : ControllerBase
    {
        private readonly IBookReturnService _bookReturn;

        public BookReturnController(IBookReturnService bookReturn)
        {
            _bookReturn = bookReturn;
        }
        /// <summary>
        /// Returns borrowed books
        /// </summary>
        /// <param name="id">book id</param>
        /// <returns></returns>
        /// <response code="200">Return successful</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal server error</response>
        [HttpPut("{userId}/Borrow/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult ReturnBook(int userId, int id)
        {
            try
            {
                var book = _bookReturn.GetBorrowedBook(userId, id);
                if (book is null)
                    return StatusCode(StatusCodes.Status404NotFound, "Borrowed book not found");

                var user = _bookReturn.ReturnBorrowedBook(userId, book);
                return Ok($"User debt is {user.Debt}");
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}

using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App1121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookBorrowController : ControllerBase
    {
        private readonly IBookBorrowService _bookBorrow;
        private readonly int maxBookCount = 5;
        private readonly ILogger<BookBorrowController> _logger;

        public BookBorrowController(IBookBorrowService bookBorrow, ILogger<BookBorrowController> logger)
        {
            _bookBorrow = bookBorrow;
            _logger = logger;
        }

        /// <summary>
        /// Borrow books
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        /// <response code="200">Return successful</response>
        /// <response code="404">Not found</response>
        /// <response code="500">Internal server error</response>
        [HttpPut("{userId}/Borrow")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult BorrowBooks(int userId, [FromBody]List<int> bookIds)
        {
            try
            {
                if (bookIds.Count() > maxBookCount)
                    return BadRequest($"Cannot borrow more than {maxBookCount} books");

                var books = _bookBorrow.GetBooks(bookIds);
                if(books == null)
                    return NotFound("Currently none of the books are available");

                if (books.Count() < bookIds.Count())
                    _logger.LogWarning("Not all books are available");

                var user = _bookBorrow.BorrowBooks(userId, books);
                if(user.ErrorMessage is not null)
                    return BadRequest(user.ErrorMessage);

                return Ok(user.BorrowedBooks);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}

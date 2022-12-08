using App1121.Enums;
using App1121.Interfaces;
using App1121.Models.Dto;
using App1121.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace App1121.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookWrapper _bookWrapper;
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBookWrapper bookWrapper,
            IBookRepository bookRepository, ILogger<BooksController> logger)
        {
            _bookWrapper = bookWrapper;
            _bookRepository = bookRepository;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<GetBookDto>> Get()
        {
            _logger.LogInformation("Retrieving all books from database");
            var books = _bookRepository.All().Select(b => _bookWrapper.Bind(b)).ToList();
            _logger.LogDebug($"List of books received: {JsonSerializer.Serialize(books)}");
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<GetBookDto> Get(int id)
        {
            _logger.LogInformation($"Retrieving book from database with id {id}");
            var book = _bookRepository.Get(id);
            var bookDTO = _bookWrapper.Bind(book);
            _logger.LogDebug($"Book received: {JsonSerializer.Serialize(bookDTO)}");
            return Ok(bookDTO);
        }

        [HttpGet("filter")]
        public ActionResult<List<GetBookDto>> Filter([FromQuery]FilterBookRequest req)
        {
            _logger.LogInformation($"Retrieving all books from database " +
                $"with parameters {JsonSerializer.Serialize(req)}");
            var books = _bookRepository.Find(b => b.Title == req.Pavadinimas
            && b.Author == req.Autorius && b.Cover == Enum.Parse<CoverType>(req.KnygosTipas));
            var booksDTO = books.Select(b => _bookWrapper.Bind(b)).ToList();
            return Ok(booksDTO);
        }

        [HttpPost]
        public IActionResult Post([FromQuery]CreateBookDto req)
        {
            _logger.LogInformation($"Creating new book: {JsonSerializer.Serialize(req)}");
            var book = _bookWrapper.Bind(req);
            _bookRepository.Create(book);
            return Ok(book.Id);
        }

        [HttpPut]
        public IActionResult Put([FromQuery]UpdateBookDto req)
        {
            _logger.LogInformation($"Updating book with id {req.Id} data: {JsonSerializer.Serialize(req)}");
            var book = _bookWrapper.Bind(req);
            _bookRepository.Update(book);
            return Ok(book.Id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation($"Deleting book with id {id}");
            var book = _bookRepository.Get(id);
            _bookRepository.Remove(book);
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}

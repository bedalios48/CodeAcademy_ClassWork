using ApiMokymai.Data;
using ApiMokymai.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiMokymai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet("ByAuthor")]
        public List<Book> GetBooksByAuthor(string author)
        {
            var books = BookData.GetBooks();
            return books.Where(b => b.Author == author).ToList();
        }
        
        [HttpGet()]
        public List<Book> GetAllBooks()
        {
            var books = BookData.GetBooks();
            return books;
        }
        
        [HttpGet("ByTitle")]
        public List<Book> GetBooksByTitle(string title)
        {
            var books = BookData.GetBooks();
            return books.Where(b => b.Title == title).ToList();
        }

        [HttpGet("ByReleaseYear")]
        public List<Book> GetBooksByReleaseYear(int releaseYear)
        {
            var books = BookData.GetBooks();
            return books.Where(b => b.ReleaseYear == releaseYear).ToList();
        }

        [HttpGet("ById")]
        public List<Book> GetBooksById(int id)
        {
            var books = BookData.GetBooks();
            return books.Where(b => b.Id == id).ToList();
        }

        [HttpGet("ByAuthorAndTitle")]
        public List<Book> GetBooksByAuthorAndTitle(string? author, string? title)
        {

            if (string.IsNullOrEmpty(author + title))
                throw new HttpRequestException("Values are empty");

            var books = BookData.GetBooks();
            if(!string.IsNullOrEmpty(author))
                books = books.Where(b => b.Author == author).ToList();

            if (!string.IsNullOrEmpty(title))
                books = books.Where(b => b.Title.Contains(title)).ToList();

            return books;
        }
    }
}

using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Interfaces
{
    public interface IBookWrapper
    {
        GetBookDto Bind(Book book);
        Book Bind(CreateBookDto createBook);
        Book Bind(UpdateBookDto updateBook);
    }
}

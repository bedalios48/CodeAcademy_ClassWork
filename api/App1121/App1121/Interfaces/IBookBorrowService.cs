using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Interfaces
{
    public interface IBookBorrowService
    {
        List<Book> GetBooks(List<int> bookIds);
        LocalUserDto BorrowBooks(int userId, List<Book> books);
    }
}

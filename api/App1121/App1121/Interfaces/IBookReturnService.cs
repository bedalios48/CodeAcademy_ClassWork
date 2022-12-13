using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Interfaces
{
    public interface IBookReturnService
    {
        Book GetBorrowedBook(int userId, int id);
        LocalUserDto ReturnBorrowedBook(int userId, Book book);
    }
}

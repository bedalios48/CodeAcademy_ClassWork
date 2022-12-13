using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Services
{
    public class BookReturnService : IBookReturnService
    {
        public Book GetBorrowedBook(int userId, int id)
        {
            return null;
        }

        public LocalUserDto ReturnBorrowedBook(int userId, Book book)
        {
            throw new NotImplementedException();
        }
    }
}

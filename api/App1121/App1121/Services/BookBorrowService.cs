using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;

namespace App1121.Services
{
    public class BookBorrowService : IBookBorrowService
    {
        public LocalUserDto BorrowBooks(int userId, List<Book> books)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooks(List<int> bookIds)
        {
            throw new NotImplementedException();
        }
    }
}

using App1121.Interfaces;
using App1121.Models;
using App1121.Models.Dto;
using App1121.Repositories.Interfaces;

namespace App1121.Services
{
    public class BookBorrowService : IBookBorrowService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBookBorrowRepository _borrowRepository;

        public BookBorrowService(IBookRepository bookRepository,
            IUserRepository userRepository,
            IBookBorrowRepository borrowRepository)
        {
            _bookRepository = bookRepository;
            _userRepository = userRepository;
            _borrowRepository = borrowRepository;
        }
        public List<BorrowedBook> BorrowBooks(int userId, List<Book> books)
        {
            var user = _userRepository.GetUser(userId);
            var borrowedBooks = books.Select(b => new BorrowedBook(DateTime.Now, user, b));
            _borrowRepository.Update(borrowedBooks);
            return borrowedBooks;
        }
/// <inheritdoc/>

        public List<Book> GetBooks(List<int> bookIds)
        {
            return bookIds.Select(id => _bookRepository.Get(id)).ToList();
        }
    }
}

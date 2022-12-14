using App1121.Models;

namespace App1121.Repositories.Interfaces
{
    public interface IBookBorrowRepository : IRepository<BorrowedBook>
    {
        void Update(IEnumerable<BorrowedBook> borrowedBooks);
    }
}

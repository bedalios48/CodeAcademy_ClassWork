using App1121.Data;
using App1121.Models;
using App1121.Repositories.Interfaces;
using System.Linq.Expressions;

namespace App1121.Repositories
{
    public class BookBorrowRepository : IBookBorrowRepository
    {
        private readonly ClassContext _db;

        public BookBorrowRepository(ClassContext context)
        {
            _db = context;
        }

        public IEnumerable<BorrowedBook> All()
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Create(BorrowedBook entity)
        {
            _db.BorrowedBooks.Add(entity);
            _db.SaveChanges();
            return entity.Id;
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> Find(Expression<Func<BorrowedBook, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public BorrowedBook Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(BorrowedBook entity)
        {
            throw new NotImplementedException();
        }

        public void Update(BorrowedBook entity)
        {
            _db.BorrowedBooks.Update(entity);
            _db.SaveChanges();
        }

        public void Update(IEnumerable<BorrowedBook> borrowedBooks)
        {
            borrowedBooks.Select(b => _db.BorrowedBooks.Update(b));
            _db.SaveChanges();
        }
    }
}

using App1121.Data;
using App1121.Models;
using App1121.Repositories.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace App1121.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ClassContext _context;

        public BookRepository(ClassContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> All()
        {
            return _context.Books;
        }

        public int Count()
        {
            return All().Count();
        }

        public int Create(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public bool Exist(int id)
        {
            return All().Any(x => x.Id == id);
        }

        public IEnumerable<Book> Find(Expression<Func<Book, bool>> predicate)
        {
            return _context.Books.Where(predicate);
        }

        public Book Get(int id)
        {
            return All().First(x => x.Id == id);
        }

        public void Remove(Book entity)
        {
            _context.Books.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }
    }
}

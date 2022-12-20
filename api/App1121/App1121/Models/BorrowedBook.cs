namespace App1121.Models
{
    public class BorrowedBook
    {
        public BorrowedBook()
        {

        }
        public BorrowedBook(int id, DateTime? borrowTime, DateTime? returnTime, LocalUser user, Book book)
        {
            Id = id;
            BorrowTime = borrowTime;
            ReturnTime = returnTime;
            User = user;
            Book = book;
        }

        public BorrowedBook(DateTime? borrowTime, LocalUser user, Book book)
        {
            BorrowTime = borrowTime;
            User = user;
            Book = book;
        }

        public int Id { get; set; }
        public DateTime? BorrowTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public virtual LocalUser User { get; set; }
        public virtual Book Book { get; set; }
    }
}

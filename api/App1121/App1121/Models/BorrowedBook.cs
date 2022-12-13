namespace App1121.Models
{
    public class BorrowedBook
    {
        public int Id { get; set; }
        public DateTime? BorrowTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public virtual LocalUser User { get; set; }
        public virtual Book Book { get; set; }
    }
}

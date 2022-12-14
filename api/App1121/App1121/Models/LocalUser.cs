namespace App1121.Models
{
    public class LocalUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; internal set; }
        public byte[] PasswordSalt { get; internal set; }
        public virtual RoleType Role { get; set; }
        public virtual List<BorrowedBook> BorrowedBooks { get; internal set; }
    }
}

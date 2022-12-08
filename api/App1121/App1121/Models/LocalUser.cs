namespace App1121.Models
{
    public class LocalUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; internal set; }
        public byte[] PasswordSalt { get; internal set; }
        public string Role { get; internal set; }
    }
}

namespace App1121.Models.Dto
{
    public class LocalUserDto
    {
        public LocalUserDto(string username, string name)
        {
            Username = username;
            Name = name;
        }

        public string Username { get; set; }
        public string Name { get; set; }
        public decimal Debt { get; set; }
        public List<GetBookDto> BorrowedBooks { get; set; }
    }
}

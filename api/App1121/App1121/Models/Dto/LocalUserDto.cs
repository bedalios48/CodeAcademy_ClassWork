namespace App1121.Models.Dto
{
    public class LocalUserDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public decimal Debt { get; set; }
        public List<GetBookDto> BorrowedBooks { get; set; }
        public string ErrorMessage { get; set; }
    }
}

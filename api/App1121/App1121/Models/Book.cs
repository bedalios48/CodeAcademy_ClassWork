using App1121.Enums;

namespace App1121.Models
{
    public class Book
    {
        public Book()
        {

        }
        public Book(int id, string title, string author,
            CoverType coverType, int publishYear)
        {
            Id = id;
            Title = title;
            Author = author;
            Cover = coverType;
            PublishYear = publishYear;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public CoverType Cover { get; set; }
        public int PublishYear { get; set; }
    }
}

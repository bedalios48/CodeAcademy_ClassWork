using App1121.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public CoverType Cover { get; set; }
        public int PublishYear { get; set; }
        public int Quantity { get; set; }
    }
}

using ApiMokymai.Models;

namespace ApiMokymai.Data
{
    public static class BookData
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Id = 1, Author = "J. K. Rowling", Title = "Harry Potter and the Philosopher's Stone", ReleaseYear = 1991},
                new Book {Id = 2, Author = "J. K. Rowling", Title = "Harry Potter and the Chamber of Secrets", ReleaseYear = 1992},
                new Book {Id = 3, Author = "J. K. Rowling", Title = "Harry Potter and the Prisoner of Azkaban", ReleaseYear = 1993},
                new Book {Id = 4, Author = "J. K. Rowling", Title = "Harry Potter and the Goblet of Fire", ReleaseYear = 1994},
                new Book {Id = 5, Author = "J. K. Rowling", Title = "Harry Potter and the Order of Phoenix", ReleaseYear = 1995},
                new Book {Id = 6, Author = "J. K. Rowling", Title = "Harry Potter and the Half Blood Prince", ReleaseYear = 1996},
                new Book {Id = 7, Author = "J. K. Rowling", Title = "Harry Potter and the Deathly Hallows", ReleaseYear = 1997},
                new Book {Id = 8, Author = "William Shakespeare", Title = "Hamlet", ReleaseYear = 1400},
                new Book {Id = 9, Author = "William Shakespeare", Title = "Macbeth", ReleaseYear = 1401},
                new Book {Id = 10, Author = "Jane Austen", Title = "Pride and Prejudice", ReleaseYear = 1790},
                new Book {Id = 11, Author = "Jane Austen", Title = "Sense and Sensibility", ReleaseYear = 1788},
                new Book {Id = 12, Author = "Vincas Mykolaitis Putinas", Title = "Altoriu Sesely", ReleaseYear = 1950},
                new Book {Id = 13, Author = "Balys Sruoga", Title = "Dievu Miskas", ReleaseYear = 1946},
                new Book {Id = 14, Author = "Alexandre Dumas", Title = "The Three Musketeers", ReleaseYear = 1800},
                new Book {Id = 15, Author = "Alexandre Dumas", Title = "Count Monte Christo", ReleaseYear = 1810}
            };
        }
    }
}

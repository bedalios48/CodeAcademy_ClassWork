using App1121.Enums;
using App1121.Models;
using Microsoft.EntityFrameworkCore;

namespace App1121.Data
{
    public class ClassContext : DbContext
    {
        public ClassContext(DbContextOptions<ClassContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(x => x.Cover)
                .HasConversion(v => v.ToString(), v => (CoverType)Enum.Parse(typeof(CoverType), v))
                .IsRequired();

            modelBuilder.Entity<Book>()
                .HasData(
                         new Book(1, "Pippi Longstocking", "Astrid Lindgren",
                        CoverType.Hardcover, 1969),
                        new Book(2, "Karlsson on the Roof", "Astrid Lindgren",
                        CoverType.Paperback, 1955),
                        new Book(3, "Emil of Lonneberga", "Astrid Lindgren",
                        CoverType.Electronic, 1970),
                        new Book(4, "The Children of Troublemaker Street",
                        "Astrid Lindgren", CoverType.Electronic, 1990),
                        new Book(5, "The Bat", "Jo Nesbo", CoverType.Hardcover,
                        1997),
                        new Book(6, "Nemesis", "Jo Nesbo", CoverType.Paperback,
                        2002),
                        new Book(7, "The Girl with the Dragon Tattoo",
                        "Stieg Larsson", CoverType.Hardcover, 2005),
                        new Book(8, "The Girl Who Played with Fire",
                        "Stieg Larsson", CoverType.Electronic, 2006),
                        new Book(9, "The Girl Who Kicked the Hornet's Nest",
                        "Stieg Larsson", CoverType.Paperback, 2007),
                        new Book(10, "The Little Mermaid", "Hans Christian Andersen",
                        CoverType.Paperback, 1836)
                );

            modelBuilder.Entity<RoleType>()
                .HasData(
                new RoleType(1, "Admin"),
                new RoleType(2, "Customer"),
                new RoleType(3, "Tester")
                );
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace App1121.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Cover", "PublishYear", "Title" },
                values: new object[,]
                {
                    { 1, "Astrid Lindgren", "Hardcover", 1969, "Pippi Longstocking" },
                    { 2, "Astrid Lindgren", "Paperback", 1955, "Karlsson on the Roof" },
                    { 3, "Astrid Lindgren", "Electronic", 1970, "Emil of Lonneberga" },
                    { 4, "Astrid Lindgren", "Electronic", 1990, "The Children of Troublemaker Street" },
                    { 5, "Jo Nesbo", "Hardcover", 1997, "The Bat" },
                    { 6, "Jo Nesbo", "Paperback", 2002, "Nemesis" },
                    { 7, "Stieg Larsson", "Hardcover", 2005, "The Girl with the Dragon Tattoo" },
                    { 8, "Stieg Larsson", "Electronic", 2006, "The Girl Who Played with Fire" },
                    { 9, "Stieg Larsson", "Paperback", 2007, "The Girl Who Kicked the Hornet's Nest" },
                    { 10, "Hans Christian Andersen", "Paperback", 1836, "The Little Mermaid" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}

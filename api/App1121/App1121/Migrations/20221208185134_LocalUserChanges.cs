using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App1121.Migrations
{
    /// <inheritdoc />
    public partial class LocalUserChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_localUsers",
                table: "localUsers");

            migrationBuilder.RenameTable(
                name: "localUsers",
                newName: "LocalUsers");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "LocalUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "LocalUsers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "LocalUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocalUsers",
                table: "LocalUsers",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LocalUsers",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "LocalUsers");

            migrationBuilder.RenameTable(
                name: "LocalUsers",
                newName: "localUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_localUsers",
                table: "localUsers",
                column: "Id");
        }
    }
}

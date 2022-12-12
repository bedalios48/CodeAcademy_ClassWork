using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App1121.Migrations
{
    /// <inheritdoc />
    public partial class RoleTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "LocalUsers");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "LocalUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RoleTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LocalUsers_RoleId",
                table: "LocalUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_LocalUsers_RoleTypes_RoleId",
                table: "LocalUsers",
                column: "RoleId",
                principalTable: "RoleTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocalUsers_RoleTypes_RoleId",
                table: "LocalUsers");

            migrationBuilder.DropTable(
                name: "RoleTypes");

            migrationBuilder.DropIndex(
                name: "IX_LocalUsers_RoleId",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "LocalUsers");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "LocalUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

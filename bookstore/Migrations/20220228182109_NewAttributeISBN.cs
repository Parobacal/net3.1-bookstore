using Microsoft.EntityFrameworkCore.Migrations;

namespace bookstore.Migrations
{
    public partial class NewAttributeISBN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Book");
        }
    }
}

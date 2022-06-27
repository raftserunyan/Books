using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class aasss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookid",
                table: "user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookid",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

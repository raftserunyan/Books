using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class user1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_userid",
                table: "Books",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_user_userid",
                table: "Books",
                column: "userid",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_user_userid",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_userid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "Books");
        }
    }
}

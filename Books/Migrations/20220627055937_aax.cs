using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class aax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Books_bookid",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_bookid",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "booksId",
                table: "user",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_booksId",
                table: "user",
                column: "booksId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Books_booksId",
                table: "user",
                column: "booksId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Books_booksId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_booksId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "booksId",
                table: "user");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user",
                newName: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_user_bookid",
                table: "user",
                column: "bookid");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Books_bookid",
                table: "user",
                column: "bookid",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

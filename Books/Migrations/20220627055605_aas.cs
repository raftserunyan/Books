using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class aas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Books_BookModelId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_BookModelId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "BookModelId",
                table: "user");

            migrationBuilder.AddColumn<int>(
                name: "bookid",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Books_bookid",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_bookid",
                table: "user");

            migrationBuilder.DropColumn(
                name: "bookid",
                table: "user");

            migrationBuilder.AddColumn<int>(
                name: "BookModelId",
                table: "user",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_BookModelId",
                table: "user",
                column: "BookModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Books_BookModelId",
                table: "user",
                column: "BookModelId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

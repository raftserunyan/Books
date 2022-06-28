using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class removedUsersListFromBookModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModelUser");

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Userid",
                table: "Books",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Users_Userid",
                table: "Books",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Users_Userid",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Userid",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookModelUser",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    Usersid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModelUser", x => new { x.BooksId, x.Usersid });
                    table.ForeignKey(
                        name: "FK_BookModelUser_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookModelUser_Users_Usersid",
                        column: x => x.Usersid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModelUser_Usersid",
                table: "BookModelUser",
                column: "Usersid");
        }
    }
}

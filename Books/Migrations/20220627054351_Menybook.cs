using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class Menybook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                        name: "FK_BookModelUser_user_Usersid",
                        column: x => x.Usersid,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModelUser_Usersid",
                table: "BookModelUser",
                column: "Usersid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModelUser");

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
    }
}

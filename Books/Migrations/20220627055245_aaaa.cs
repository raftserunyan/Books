using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class aaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookModelUser");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BookModelUser",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookModelUser", x => new { x.BooksId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_BookModelUser_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookModelUser_user_UsersId",
                        column: x => x.UsersId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookModelUser_UsersId",
                table: "BookModelUser",
                column: "UsersId");
        }
    }
}

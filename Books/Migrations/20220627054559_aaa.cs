using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookModelUser_user_Usersid",
                table: "BookModelUser");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "user",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Usersid",
                table: "BookModelUser",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_BookModelUser_Usersid",
                table: "BookModelUser",
                newName: "IX_BookModelUser_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookModelUser_user_UsersId",
                table: "BookModelUser",
                column: "UsersId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookModelUser_user_UsersId",
                table: "BookModelUser");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "user",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "BookModelUser",
                newName: "Usersid");

            migrationBuilder.RenameIndex(
                name: "IX_BookModelUser_UsersId",
                table: "BookModelUser",
                newName: "IX_BookModelUser_Usersid");

            migrationBuilder.AddForeignKey(
                name: "FK_BookModelUser_user_Usersid",
                table: "BookModelUser",
                column: "Usersid",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

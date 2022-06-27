using Microsoft.EntityFrameworkCore.Migrations;

namespace Books.Migrations
{
    public partial class KapPropertyRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBookKaps_Users_Userid",
                table: "UserBookKaps");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "UserBookKaps");

            migrationBuilder.RenameColumn(
                name: "Userid",
                table: "UserBookKaps",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserBookKaps_Userid",
                table: "UserBookKaps",
                newName: "IX_UserBookKaps_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserBookKaps",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookKaps_Users_UserId",
                table: "UserBookKaps",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBookKaps_Users_UserId",
                table: "UserBookKaps");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserBookKaps",
                newName: "Userid");

            migrationBuilder.RenameIndex(
                name: "IX_UserBookKaps_UserId",
                table: "UserBookKaps",
                newName: "IX_UserBookKaps_Userid");

            migrationBuilder.AlterColumn<int>(
                name: "Userid",
                table: "UserBookKaps",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "UserBookKaps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookKaps_Users_Userid",
                table: "UserBookKaps",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

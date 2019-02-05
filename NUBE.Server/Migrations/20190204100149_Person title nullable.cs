using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class Persontitlenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PersonTitleId",
                table: "Members",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Members_PersonTitleId",
                table: "Members",
                column: "PersonTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_PersonTitles_PersonTitleId",
                table: "Members",
                column: "PersonTitleId",
                principalTable: "PersonTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_PersonTitles_PersonTitleId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_PersonTitleId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "PersonTitleId",
                table: "Members",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}

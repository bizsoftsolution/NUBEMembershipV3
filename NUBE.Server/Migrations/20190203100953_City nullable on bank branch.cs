using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class Citynullableonbankbranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_Cities_CityId",
                table: "BankBranches");

            migrationBuilder.AddColumn<bool>(
                name: "Resign",
                table: "Members",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "BankBranches",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_Cities_CityId",
                table: "BankBranches",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_Cities_CityId",
                table: "BankBranches");

            migrationBuilder.DropColumn(
                name: "Resign",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "BankBranches",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_Cities_CityId",
                table: "BankBranches",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

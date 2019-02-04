using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class AddedCodeFieldforv2key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemberCode",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityCode",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankCode",
                table: "Banks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankBranchCode",
                table: "BankBranches",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberCode",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CityCode",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "BankCode",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "BankBranchCode",
                table: "BankBranches");
        }
    }
}

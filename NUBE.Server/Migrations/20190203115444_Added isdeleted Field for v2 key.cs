using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class AddedisdeletedFieldforv2key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StateCode",
                table: "States",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "States",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BranchCode",
                table: "OrganisationBranchDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "OrganisationBranchDetails",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Cities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Banks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "BankBranches",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateCode",
                table: "States");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "States");

            migrationBuilder.DropColumn(
                name: "BranchCode",
                table: "OrganisationBranchDetails");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "OrganisationBranchDetails");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "BankBranches");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class nubebranchcodenullableonbankbranch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_OrganisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationBranchDetailId",
                table: "BankBranches",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_OrganisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches",
                column: "OrganisationBranchDetailId",
                principalTable: "OrganisationBranchDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_OrganisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches");

            migrationBuilder.AlterColumn<int>(
                name: "OrganisationBranchDetailId",
                table: "BankBranches",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_OrganisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches",
                column: "OrganisationBranchDetailId",
                principalTable: "OrganisationBranchDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

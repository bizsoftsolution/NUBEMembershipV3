using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MemberType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_organisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_organisationBranchDetails",
                table: "organisationBranchDetails");

            migrationBuilder.RenameTable(
                name: "organisationBranchDetails",
                newName: "OrganisationBranchDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrganisationBranchDetails",
                table: "OrganisationBranchDetails",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MemberTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_OrganisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches",
                column: "OrganisationBranchDetailId",
                principalTable: "OrganisationBranchDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranches_OrganisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches");

            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrganisationBranchDetails",
                table: "OrganisationBranchDetails");

            migrationBuilder.RenameTable(
                name: "OrganisationBranchDetails",
                newName: "organisationBranchDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_organisationBranchDetails",
                table: "organisationBranchDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranches_organisationBranchDetails_OrganisationBranchDetailId",
                table: "BankBranches",
                column: "OrganisationBranchDetailId",
                principalTable: "organisationBranchDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

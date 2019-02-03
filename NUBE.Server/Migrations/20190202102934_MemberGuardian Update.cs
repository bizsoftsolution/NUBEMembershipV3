using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MemberGuardianUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians");

            migrationBuilder.DropColumn(
                name: "RelatonshipId",
                table: "MemberGuardians");

            migrationBuilder.RenameColumn(
                name: "RelatonshipId",
                table: "MemberNominees",
                newName: "RelatoinshipId");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberGuardians",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians");

            migrationBuilder.RenameColumn(
                name: "RelatoinshipId",
                table: "MemberNominees",
                newName: "RelatonshipId");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberGuardians",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RelatonshipId",
                table: "MemberGuardians",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

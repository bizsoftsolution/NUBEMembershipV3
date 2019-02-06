using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class Relationshipidisnullableonmember : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberNominees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "MemberNominees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberGuardians",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "MemberGuardians",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberGuardians_Relationships_RelationshipId",
                table: "MemberGuardians");

            migrationBuilder.DropForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberNominees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "MemberNominees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberGuardians",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
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

            migrationBuilder.AddForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

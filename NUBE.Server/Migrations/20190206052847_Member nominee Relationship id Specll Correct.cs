using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MembernomineeRelationshipidSpecllCorrect : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "RelatoinshipId",
                table: "MemberNominees");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberNominees",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees");

            migrationBuilder.AlterColumn<int>(
                name: "RelationshipId",
                table: "MemberNominees",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RelatoinshipId",
                table: "MemberNominees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees",
                column: "RelationshipId",
                principalTable: "Relationships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

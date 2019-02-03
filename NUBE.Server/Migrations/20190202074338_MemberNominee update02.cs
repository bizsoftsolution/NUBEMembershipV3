using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MemberNomineeupdate02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelationshipId",
                table: "MemberNominees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RelatonshipId",
                table: "MemberNominees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MemberNominees_RelationshipId",
                table: "MemberNominees",
                column: "RelationshipId");

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
                name: "FK_MemberNominees_Relationships_RelationshipId",
                table: "MemberNominees");

            migrationBuilder.DropIndex(
                name: "IX_MemberNominees_RelationshipId",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "RelationshipId",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "RelatonshipId",
                table: "MemberNominees");
        }
    }
}

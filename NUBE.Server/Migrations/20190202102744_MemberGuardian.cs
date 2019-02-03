using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MemberGuardian : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberGuardians",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    NRIC_O = table.Column<string>(nullable: true),
                    NRIC_N = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    MemberId = table.Column<int>(nullable: false),
                    RelatonshipId = table.Column<int>(nullable: false),
                    RelationshipId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberGuardians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberGuardians_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberGuardians_Relationships_RelationshipId",
                        column: x => x.RelationshipId,
                        principalTable: "Relationships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberGuardians_MemberId",
                table: "MemberGuardians",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberGuardians_RelationshipId",
                table: "MemberGuardians",
                column: "RelationshipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberGuardians");
        }
    }
}

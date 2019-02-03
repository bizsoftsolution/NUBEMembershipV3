using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class Member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberType = table.Column<string>(nullable: false),
                    MemberNo = table.Column<string>(nullable: true),
                    PersonTitleId = table.Column<int>(nullable: false),
                    MemberName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    Race = table.Column<string>(nullable: false),
                    ReJoin = table.Column<bool>(nullable: false),
                    NRIC_O = table.Column<string>(nullable: true),
                    NRIC_N = table.Column<string>(nullable: true),
                    DOJ = table.Column<DateTime>(nullable: false),
                    DOE = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    Levy = table.Column<string>(nullable: false),
                    LevyAmount = table.Column<decimal>(nullable: false),
                    TDF = table.Column<string>(nullable: false),
                    TDFAmount = table.Column<decimal>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false),
                    PostalCode = table.Column<string>(nullable: true),
                    PhoneNo = table.Column<string>(nullable: true),
                    MobileNo = table.Column<string>(nullable: true),
                    EMailId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_CityId",
                table: "Members",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}

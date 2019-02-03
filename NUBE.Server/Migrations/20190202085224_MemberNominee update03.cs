using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MemberNomineeupdate03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "MemberNominees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "MemberNominees");
        }
    }
}

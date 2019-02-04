using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class Memberfunddetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Cities_CityId",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Members",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "DOL",
                table: "Members",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "MemberFundDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntranceFee = table.Column<decimal>(nullable: false),
                    BuildingFund = table.Column<decimal>(nullable: false),
                    AccBenefit = table.Column<decimal>(nullable: false),
                    BadgeAmt = table.Column<decimal>(nullable: false),
                    ServicePeriod = table.Column<decimal>(nullable: false),
                    SubsMonthly = table.Column<decimal>(nullable: false),
                    SubsYtd = table.Column<decimal>(nullable: false),
                    SubsAcc = table.Column<decimal>(nullable: false),
                    SubsPaid = table.Column<decimal>(nullable: false),
                    SubsDue = table.Column<decimal>(nullable: false),
                    BFMonthly = table.Column<decimal>(nullable: false),
                    BFYtd = table.Column<decimal>(nullable: false),
                    BFAcc = table.Column<decimal>(nullable: false),
                    BFPaid = table.Column<decimal>(nullable: false),
                    BFDue = table.Column<decimal>(nullable: false),
                    UCMonthly = table.Column<decimal>(nullable: false),
                    UCYtd = table.Column<decimal>(nullable: false),
                    UCAcc = table.Column<decimal>(nullable: false),
                    UCPaid = table.Column<decimal>(nullable: false),
                    UCDue = table.Column<decimal>(nullable: false),
                    InsMonthly = table.Column<decimal>(nullable: false),
                    InsYtd = table.Column<decimal>(nullable: false),
                    InsAcc = table.Column<decimal>(nullable: false),
                    InsPaid = table.Column<decimal>(nullable: false),
                    InsDue = table.Column<decimal>(nullable: false),
                    GE = table.Column<decimal>(nullable: false),
                    AI = table.Column<decimal>(nullable: false),
                    TakafulPaidMonths = table.Column<decimal>(nullable: false),
                    TDF = table.Column<decimal>(nullable: false),
                    MemberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberFundDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberFundDetail_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberFundDetail_MemberId",
                table: "MemberFundDetail",
                column: "MemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Cities_CityId",
                table: "Members",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Cities_CityId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "MemberFundDetail");

            migrationBuilder.DropColumn(
                name: "DOL",
                table: "Members");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Members",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Cities_CityId",
                table: "Members",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

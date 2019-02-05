using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class Memberupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GE",
                table: "MemberFundDetail",
                newName: "RegistrationFee");

            migrationBuilder.RenameColumn(
                name: "AI",
                table: "MemberFundDetail",
                newName: "HQFee");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOL",
                table: "Members",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOJ",
                table: "Members",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOE",
                table: "Members",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Members",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "BFNo",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BankBranchId",
                table: "Members",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BankCode_ByBank",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LevyPayDate",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MembeerStatus",
                table: "Members",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MemberName_ByBank",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NRIC_ByBank",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TDFPayDate",
                table: "Members",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalMonthDue",
                table: "Members",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalMonthPaid",
                table: "Members",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "AI_Insurance",
                table: "MemberFundDetail",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AI_InsuranceNo",
                table: "MemberFundDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GE_ContractNo",
                table: "MemberFundDetail",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "GE_Insurance",
                table: "MemberFundDetail",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Members_BankBranchId",
                table: "Members",
                column: "BankBranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_BankBranches_BankBranchId",
                table: "Members",
                column: "BankBranchId",
                principalTable: "BankBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_BankBranches_BankBranchId",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_Members_BankBranchId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BFNo",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BankBranchId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BankCode_ByBank",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "LevyPayDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MembeerStatus",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "MemberName_ByBank",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "NRIC_ByBank",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TDFPayDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TotalMonthDue",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TotalMonthPaid",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "AI_Insurance",
                table: "MemberFundDetail");

            migrationBuilder.DropColumn(
                name: "AI_InsuranceNo",
                table: "MemberFundDetail");

            migrationBuilder.DropColumn(
                name: "GE_ContractNo",
                table: "MemberFundDetail");

            migrationBuilder.DropColumn(
                name: "GE_Insurance",
                table: "MemberFundDetail");

            migrationBuilder.RenameColumn(
                name: "RegistrationFee",
                table: "MemberFundDetail",
                newName: "GE");

            migrationBuilder.RenameColumn(
                name: "HQFee",
                table: "MemberFundDetail",
                newName: "AI");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOL",
                table: "Members",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOJ",
                table: "Members",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOE",
                table: "Members",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DOB",
                table: "Members",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}

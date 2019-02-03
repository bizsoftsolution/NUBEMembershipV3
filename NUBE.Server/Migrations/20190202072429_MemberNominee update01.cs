using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class MemberNomineeupdate01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "MemberNominees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "MemberNominees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "MemberNominees",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNo",
                table: "MemberNominees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NRIC_N",
                table: "MemberNominees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NRIC_O",
                table: "MemberNominees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "MemberNominees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                table: "MemberNominees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "NRIC_N",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "NRIC_O",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "MemberNominees");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                table: "MemberNominees");
        }
    }
}

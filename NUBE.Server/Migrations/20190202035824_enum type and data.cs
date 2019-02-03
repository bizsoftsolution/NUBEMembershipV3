using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NUBE.Server.Migrations
{
    public partial class enumtypeanddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberTypes");

            migrationBuilder.CreateTable(
                name: "ENumTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENumTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ENumDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ENumTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENumDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ENumDatas_ENumTypes_ENumTypeId",
                        column: x => x.ENumTypeId,
                        principalTable: "ENumTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ENumDatas_ENumTypeId",
                table: "ENumDatas",
                column: "ENumTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ENumDatas");

            migrationBuilder.DropTable(
                name: "ENumTypes");

            migrationBuilder.CreateTable(
                name: "MemberTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTypes", x => x.Id);
                });
        }
    }
}

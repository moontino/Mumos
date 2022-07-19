using Microsoft.EntityFrameworkCore.Migrations;

namespace Mumos.Data.Migrations
{
    public partial class AddIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyTechnology");

            migrationBuilder.DropTable(
                name: "JobTechnology");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Technologies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Technologies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_CompanyId",
                table: "Technologies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_JobId",
                table: "Technologies",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Technologies_Companies_CompanyId",
                table: "Technologies",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technologies_Jobs_JobId",
                table: "Technologies",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Technologies_Companies_CompanyId",
                table: "Technologies");

            migrationBuilder.DropForeignKey(
                name: "FK_Technologies_Jobs_JobId",
                table: "Technologies");

            migrationBuilder.DropIndex(
                name: "IX_Technologies_CompanyId",
                table: "Technologies");

            migrationBuilder.DropIndex(
                name: "IX_Technologies_JobId",
                table: "Technologies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Technologies");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Technologies");

            migrationBuilder.CreateTable(
                name: "CompanyTechnology",
                columns: table => new
                {
                    CompaniesId = table.Column<int>(type: "int", nullable: false),
                    TechnologiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTechnology", x => new { x.CompaniesId, x.TechnologiesId });
                    table.ForeignKey(
                        name: "FK_CompanyTechnology_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyTechnology_Technologies_TechnologiesId",
                        column: x => x.TechnologiesId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobTechnology",
                columns: table => new
                {
                    JobsId = table.Column<int>(type: "int", nullable: false),
                    TechnologiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTechnology", x => new { x.JobsId, x.TechnologiesId });
                    table.ForeignKey(
                        name: "FK_JobTechnology_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobTechnology_Technologies_TechnologiesId",
                        column: x => x.TechnologiesId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTechnology_TechnologiesId",
                table: "CompanyTechnology",
                column: "TechnologiesId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTechnology_TechnologiesId",
                table: "JobTechnology",
                column: "TechnologiesId");
        }
    }
}

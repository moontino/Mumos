using Microsoft.EntityFrameworkCore.Migrations;

namespace Mumos.Data.Migrations
{
    public partial class AddDbSetIndustry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Technologies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Jobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_IndustryId",
                table: "Technologies",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_IndustryId",
                table: "Jobs",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IndustryId",
                table: "Companies",
                column: "IndustryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Technologies_Industries_IndustryId",
                table: "Technologies",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Technologies_Industries_IndustryId",
                table: "Technologies");

            migrationBuilder.DropTable(
                name: "Industries");

            migrationBuilder.DropIndex(
                name: "IX_Technologies_IndustryId",
                table: "Technologies");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_IndustryId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Companies_IndustryId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Technologies");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Companies");
        }
    }
}

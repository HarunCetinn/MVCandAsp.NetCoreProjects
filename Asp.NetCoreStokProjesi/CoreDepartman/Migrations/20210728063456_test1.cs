using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartman.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departId",
                table: "personels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_personels_departId",
                table: "personels",
                column: "departId");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departId",
                table: "personels",
                column: "departId",
                principalTable: "departmanlars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departId",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_departId",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "departId",
                table: "personels");
        }
    }
}

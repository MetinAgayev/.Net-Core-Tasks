using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEnd.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_section1search_section1_section1Id",
                table: "section1search");

            migrationBuilder.AlterColumn<int>(
                name: "section1Id",
                table: "section1search",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_section1search_section1_section1Id",
                table: "section1search",
                column: "section1Id",
                principalTable: "section1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_section1search_section1_section1Id",
                table: "section1search");

            migrationBuilder.AlterColumn<int>(
                name: "section1Id",
                table: "section1search",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_section1search_section1_section1Id",
                table: "section1search",
                column: "section1Id",
                principalTable: "section1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

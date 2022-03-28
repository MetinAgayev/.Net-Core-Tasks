using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBackEnd.Migrations
{
    public partial class CreatedTableSection2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_section1search_section1_section1Id",
                table: "section1search");

            migrationBuilder.DropPrimaryKey(
                name: "PK_section1search",
                table: "section1search");

            migrationBuilder.DropPrimaryKey(
                name: "PK_section1",
                table: "section1");

            migrationBuilder.RenameTable(
                name: "section1search",
                newName: "Section1search");

            migrationBuilder.RenameTable(
                name: "section1",
                newName: "Section1");

            migrationBuilder.RenameColumn(
                name: "section1Id",
                table: "Section1search",
                newName: "Section1Id");

            migrationBuilder.RenameIndex(
                name: "IX_section1search_section1Id",
                table: "Section1search",
                newName: "IX_Section1search_Section1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section1search",
                table: "Section1search",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section1",
                table: "Section1",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Section2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Procate = table.Column<string>(maxLength: 255, nullable: true),
                    Price = table.Column<string>(maxLength: 255, nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Image = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section2", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Section1search_Section1_Section1Id",
                table: "Section1search",
                column: "Section1Id",
                principalTable: "Section1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section1search_Section1_Section1Id",
                table: "Section1search");

            migrationBuilder.DropTable(
                name: "Section2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section1search",
                table: "Section1search");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section1",
                table: "Section1");

            migrationBuilder.RenameTable(
                name: "Section1search",
                newName: "section1search");

            migrationBuilder.RenameTable(
                name: "Section1",
                newName: "section1");

            migrationBuilder.RenameColumn(
                name: "Section1Id",
                table: "section1search",
                newName: "section1Id");

            migrationBuilder.RenameIndex(
                name: "IX_Section1search_Section1Id",
                table: "section1search",
                newName: "IX_section1search_section1Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_section1search",
                table: "section1search",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_section1",
                table: "section1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_section1search_section1_section1Id",
                table: "section1search",
                column: "section1Id",
                principalTable: "section1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

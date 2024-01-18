using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniProject002.Migrations
{
    /// <inheritdoc />
    public partial class CreateDB002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MiniProject002_Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiniProject002_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MiniProject002_Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MiniProject002_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MiniProject002_Products_MiniProject002_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "MiniProject002_Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MiniProject002_Products_CategoryId",
                table: "MiniProject002_Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MiniProject002_Products");

            migrationBuilder.DropTable(
                name: "MiniProject002_Categories");
        }
    }
}

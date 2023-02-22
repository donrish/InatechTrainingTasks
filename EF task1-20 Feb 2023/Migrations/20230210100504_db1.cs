using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCONSOLE.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productbatch",
                columns: table => new
                {
                    batchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Productfk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productbatch", x => x.batchId);
                    table.ForeignKey(
                        name: "FK_Productbatch_Products_Productfk",
                        column: x => x.Productfk,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productbatch_Productfk",
                table: "Productbatch",
                column: "Productfk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productbatch");
        }
    }
}

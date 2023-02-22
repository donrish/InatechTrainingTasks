using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCONSOLE.Migrations
{
    /// <inheritdoc />
    public partial class student13feb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "standards",
                columns: table => new
                {
                    Standardid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Standardname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_standards", x => x.Standardid);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Studentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Standardrefid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Studentid);
                    table.ForeignKey(
                        name: "FK_students_standards_Standardrefid",
                        column: x => x.Standardrefid,
                        principalTable: "standards",
                        principalColumn: "Standardid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_Standardrefid",
                table: "students",
                column: "Standardrefid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "standards");
        }
    }
}

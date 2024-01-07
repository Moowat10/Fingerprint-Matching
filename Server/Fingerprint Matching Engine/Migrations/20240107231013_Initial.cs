using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fingerprint_Matching_Engine.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fingers",
                columns: table => new
                {
                    FingerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpolyeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeFinger = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fingers", x => x.FingerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fingers");
        }
    }
}

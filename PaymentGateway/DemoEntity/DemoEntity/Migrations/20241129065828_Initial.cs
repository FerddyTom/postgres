using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEntity.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jutsus",
                columns: table => new
                {
                    JutsuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JutsuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JutsuDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jutsus", x => x.JutsuId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jutsus");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace GezginTurizm.DataAccess.Migrations
{
    public partial class AddContactEditService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactEdits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Maps = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    Phone1 = table.Column<int>(nullable: false),
                    Phone2 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactEdits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactEdits");
        }
    }
}

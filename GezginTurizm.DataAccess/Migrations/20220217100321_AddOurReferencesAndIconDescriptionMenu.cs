using Microsoft.EntityFrameworkCore.Migrations;

namespace GezginTurizm.DataAccess.Migrations
{
    public partial class AddOurReferencesAndIconDescriptionMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IconDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IconDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OurReferences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceWebSite = table.Column<string>(nullable: true),
                    ReferenceLogo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurReferences", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IconDescriptions");

            migrationBuilder.DropTable(
                name: "OurReferences");
        }
    }
}

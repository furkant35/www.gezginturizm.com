using Microsoft.EntityFrameworkCore.Migrations;

namespace GezginTurizm.DataAccess.Migrations
{
    public partial class AddOurHistoryPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "OurHistories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AboutUsPhoto",
                table: "Institutionals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OurMissionPhoto",
                table: "Institutionals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OurVisionPhoto",
                table: "Institutionals",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "OurHistories");

            migrationBuilder.DropColumn(
                name: "AboutUsPhoto",
                table: "Institutionals");

            migrationBuilder.DropColumn(
                name: "OurMissionPhoto",
                table: "Institutionals");

            migrationBuilder.DropColumn(
                name: "OurVisionPhoto",
                table: "Institutionals");
        }
    }
}

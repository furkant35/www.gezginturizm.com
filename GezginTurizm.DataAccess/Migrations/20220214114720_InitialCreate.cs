using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GezginTurizm.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Password = table.Column<string>(type: "Varchar(10)", nullable: true),
                    SecretQuestion = table.Column<string>(nullable: true),
                    SecretAnswer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(nullable: true),
                    ContactEmail = table.Column<string>(nullable: true),
                    ContactSubject = table.Column<string>(nullable: true),
                    ContactMessage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTransports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceCategoryId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutionals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutUs = table.Column<string>(nullable: true),
                    OurMission = table.Column<string>(nullable: true),
                    OurVision = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutionals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhotoGalleries",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoGalleries", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderPhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "StudentTransports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceCategoryId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VipTransports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceCategoryId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VipTransports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkerWithoutVehicles",
                columns: table => new
                {
                    WorkerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerName = table.Column<string>(nullable: true),
                    WorkerSurname = table.Column<string>(nullable: true),
                    WorkerDateOfBirth = table.Column<DateTime>(nullable: false),
                    WorkerPhone = table.Column<string>(nullable: true),
                    WorkerAddress = table.Column<string>(nullable: true),
                    WorkerRetirementStatus = table.Column<bool>(nullable: false),
                    WorkerWorkStatus = table.Column<bool>(nullable: false),
                    WorkerDriverLicenseType = table.Column<string>(nullable: true),
                    WorkerDriverLicenseDate = table.Column<DateTime>(nullable: false),
                    WorkerPsychotechnics = table.Column<bool>(nullable: false),
                    WorkerDriverIntroduction = table.Column<bool>(nullable: false),
                    WorkerWorkExperience = table.Column<string>(nullable: true),
                    Explanation = table.Column<string>(nullable: true),
                    WorkerSRC1 = table.Column<bool>(nullable: false),
                    WorkerSRC2 = table.Column<bool>(nullable: false),
                    WorkerSRC3 = table.Column<bool>(nullable: false),
                    WorkerSRC4 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerWithoutVehicles", x => x.WorkerId);
                });

            migrationBuilder.CreateTable(
                name: "WorkerWithVehicles",
                columns: table => new
                {
                    WorkerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiclePlate = table.Column<string>(nullable: true),
                    VehicleBrand = table.Column<string>(nullable: true),
                    VehicleModel = table.Column<int>(nullable: false),
                    VehicleType = table.Column<string>(nullable: true),
                    VehicleColor = table.Column<string>(nullable: true),
                    VehicleSeatNumber = table.Column<int>(nullable: false),
                    VehiclePersonToWork = table.Column<bool>(nullable: false),
                    WorkerName = table.Column<string>(nullable: true),
                    WorkerPhone = table.Column<string>(nullable: true),
                    WorkerAddress = table.Column<string>(nullable: true),
                    WorkerWorkingStatus = table.Column<bool>(nullable: false),
                    WorkerRetirementStatus = table.Column<bool>(nullable: false),
                    DocumentDriverLicenseType = table.Column<string>(nullable: true),
                    DocumentDriverLicenseDate = table.Column<DateTime>(nullable: false),
                    DocumentPsychoTechnics = table.Column<bool>(nullable: false),
                    DocumentDriverIntroduction = table.Column<bool>(nullable: false),
                    DocumentWorkExperience = table.Column<string>(nullable: true),
                    DocumentReference = table.Column<string>(nullable: true),
                    DocumentExplanation = table.Column<string>(nullable: true),
                    DocumentSRC1 = table.Column<bool>(nullable: false),
                    DocumentSRC2 = table.Column<bool>(nullable: false),
                    DocumentSRC3 = table.Column<bool>(nullable: false),
                    DocumentSRC4 = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerWithVehicles", x => x.WorkerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EmployeeTransports");

            migrationBuilder.DropTable(
                name: "Institutionals");

            migrationBuilder.DropTable(
                name: "PhotoGalleries");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "StudentTransports");

            migrationBuilder.DropTable(
                name: "VipTransports");

            migrationBuilder.DropTable(
                name: "WorkerWithoutVehicles");

            migrationBuilder.DropTable(
                name: "WorkerWithVehicles");
        }
    }
}

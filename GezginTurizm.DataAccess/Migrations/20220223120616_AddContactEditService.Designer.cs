﻿// <auto-generated />
using System;
using GezginTurizm.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GezginTurizm.DataAccess.Migrations
{
    [DbContext(typeof(GezginContext))]
    [Migration("20220223120616_AddContactEditService")]
    partial class AddContactEditService
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("Varchar(10)");

                    b.Property<string>("SecretAnswer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecretQuestion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("Varchar(20)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isRead")
                        .HasColumnType("bit");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.ContactEdit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Maps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone1")
                        .HasColumnType("int");

                    b.Property<int>("Phone2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ContactEdits");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.EmployeeTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ServiceCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeTransports");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.IconDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IconDescriptions");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.Institutional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurMission")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OurVision")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Institutionals");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.OurHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OurHistories");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.OurReferences", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReferenceLogo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceWebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OurReferences");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.PhotoGallery", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhotoName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoId");

                    b.ToTable("PhotoGalleries");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SliderPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SliderId");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.StudentTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ServiceCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentTransports");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.VipTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ServiceCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VipTransports");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.WorkerWithVehicle", b =>
                {
                    b.Property<int>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DocumentDriverIntroduction")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DocumentDriverLicenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentDriverLicenseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentExplanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DocumentPsychoTechnics")
                        .HasColumnType("bit");

                    b.Property<string>("DocumentReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DocumentSRC1")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentSRC2")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentSRC3")
                        .HasColumnType("bit");

                    b.Property<bool>("DocumentSRC4")
                        .HasColumnType("bit");

                    b.Property<string>("DocumentWorkExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VehicleColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleModel")
                        .HasColumnType("int");

                    b.Property<bool>("VehiclePersonToWork")
                        .HasColumnType("bit");

                    b.Property<string>("VehiclePlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleSeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("VehicleType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WorkerRetirementStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("WorkerWorkingStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("isRead")
                        .HasColumnType("bit");

                    b.HasKey("WorkerId");

                    b.ToTable("WorkerWithVehicles");
                });

            modelBuilder.Entity("GezginTurizm.Entities.Concrete.WorkerWithoutVehicle", b =>
                {
                    b.Property<int>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WorkerDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<bool>("WorkerDriverIntroduction")
                        .HasColumnType("bit");

                    b.Property<DateTime>("WorkerDriverLicenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkerDriverLicenseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WorkerPsychotechnics")
                        .HasColumnType("bit");

                    b.Property<bool>("WorkerRetirementStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("WorkerSRC1")
                        .HasColumnType("bit");

                    b.Property<bool>("WorkerSRC2")
                        .HasColumnType("bit");

                    b.Property<bool>("WorkerSRC3")
                        .HasColumnType("bit");

                    b.Property<bool>("WorkerSRC4")
                        .HasColumnType("bit");

                    b.Property<string>("WorkerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerWorkExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WorkerWorkStatus")
                        .HasColumnType("bit");

                    b.Property<bool>("isRead")
                        .HasColumnType("bit");

                    b.HasKey("WorkerId");

                    b.ToTable("WorkerWithoutVehicles");
                });
#pragma warning restore 612, 618
        }
    }
}

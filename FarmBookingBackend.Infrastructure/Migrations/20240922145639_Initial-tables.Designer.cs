﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using FarmBookingBackend.Infrastructure.Data;

#nullable disable

namespace FarmBookingBackend.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240922145639_Initial-tables")]
    partial class Initialtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "73820363-480e-443c-866d-cf8b44129328",
                            Name = "customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "9f44d25c-9335-4e68-909e-efc977c27a44",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Private Pool"
                        },
                        new
                        {
                            Id = 2,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Microwave"
                        },
                        new
                        {
                            Id = 3,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Private Balcony"
                        },
                        new
                        {
                            Id = 5,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 2,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Private Plunge Pool"
                        },
                        new
                        {
                            Id = 6,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 2,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Microwave and Mini Refrigerator"
                        },
                        new
                        {
                            Id = 7,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 2,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Private Balcony"
                        },
                        new
                        {
                            Id = 9,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 3,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Private Pool"
                        },
                        new
                        {
                            Id = 10,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 3,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Jacuzzi"
                        },
                        new
                        {
                            Id = 11,
                            Created_Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FarmId = 3,
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Private Balcony"
                        });
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPaymentSuccessful")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nights")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FarmId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Farms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4287),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\FarmImage\\a78075cc-2905-4471-a578-1d5fe3945fcd.jpg",
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Royal Farm",
                            Occupancy = 4,
                            Price = 200.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4369),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\FarmImage\\cac7e1b4-5ba4-493f-9b73-14434d5b56d7.jpg",
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Premium Pool Farm",
                            Occupancy = 4,
                            Price = 300.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 3,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4386),
                            Description = "Fusce 11 tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                            ImageUrl = "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\FarmImage\\d75cb0ad-9ed1-46af-87bc-fa99e00b2e58.jpg",
                            IsAvailable = true,
                            IsDelete = false,
                            Name = "Luxury Pool Farm",
                            Occupancy = 4,
                            Price = 400.0,
                            Sqft = 750
                        });
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.FarmRoom", b =>
                {
                    b.Property<int>("FarmRoom_Number")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("SpecialDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("FarmRoom_Number");

                    b.HasIndex("FarmId");

                    b.ToTable("FarmRooms");

                    b.HasData(
                        new
                        {
                            FarmRoom_Number = 101,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4616),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "Master bedroom"
                        },
                        new
                        {
                            FarmRoom_Number = 102,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4634),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "has 3 bed"
                        },
                        new
                        {
                            FarmRoom_Number = 103,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4645),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "has 3 bed"
                        },
                        new
                        {
                            FarmRoom_Number = 104,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4654),
                            FarmId = 1,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "has 2 bed"
                        },
                        new
                        {
                            FarmRoom_Number = 201,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4664),
                            FarmId = 2,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "Master bedroom"
                        },
                        new
                        {
                            FarmRoom_Number = 202,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4672),
                            FarmId = 2,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "has 2 bed"
                        },
                        new
                        {
                            FarmRoom_Number = 203,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4680),
                            FarmId = 2,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "has 2 bed"
                        },
                        new
                        {
                            FarmRoom_Number = 301,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4688),
                            FarmId = 3,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "Master bedroom"
                        },
                        new
                        {
                            FarmRoom_Number = 302,
                            Created_Date = new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4696),
                            FarmId = 3,
                            IsAvailable = true,
                            IsDelete = false,
                            SpecialDetails = "has 2 bed"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FarmBookingBackend.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FarmBookingBackend.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBookingBackend.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FarmBookingBackend.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.Amenity", b =>
                {
                    b.HasOne("FarmBookingBackend.Domain.Entities.Farm", "Farm")
                        .WithMany("Amenities")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.Booking", b =>
                {
                    b.HasOne("FarmBookingBackend.Domain.Entities.Farm", "Farm")
                        .WithOne("Booking")
                        .HasForeignKey("FarmBookingBackend.Domain.Entities.Booking", "FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBookingBackend.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.FarmRoom", b =>
                {
                    b.HasOne("FarmBookingBackend.Domain.Entities.Farm", "Farm")
                        .WithMany("FarmRooms")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("FarmBookingBackend.Domain.Entities.Farm", b =>
                {
                    b.Navigation("Amenities");

                    b.Navigation("Booking");

                    b.Navigation("FarmRooms");
                });
#pragma warning restore 612, 618
        }
    }
}

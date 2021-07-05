﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Walkabouts.Repository.Context;

namespace Walkabouts.Repository.Migrations
{
    [DbContext(typeof(WalkaboutsDbContext))]
    [Migration("20210701191408_addProductRelationships")]
    partial class addProductRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.AppRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

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

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("ShoppingCartId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.Payment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.PaymentOption", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("UserWalletId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserWalletId");

                    b.ToTable("PaymentOption");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StockLevel")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedBy = 0L,
                            CreatedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(8490),
                            Description = "",
                            Featured = false,
                            ModifiedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(8526),
                            ProductName = "Samsung 50 inch",
                            RefId = new Guid("baa4e4ff-ae21-459b-bc83-1e19583ee13e"),
                            StockLevel = 15,
                            UnitPrice = 3400m
                        },
                        new
                        {
                            Id = 2L,
                            CreatedBy = 0L,
                            CreatedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9973),
                            Description = "energy saving product",
                            Featured = false,
                            ModifiedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9975),
                            ProductName = "SkyRun Fridge",
                            RefId = new Guid("57a1b119-80d9-45ad-a50a-32609f8ddd11"),
                            StockLevel = 11,
                            UnitPrice = 4000m
                        },
                        new
                        {
                            Id = 3L,
                            CreatedBy = 0L,
                            CreatedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9985),
                            Description = "",
                            Featured = false,
                            ModifiedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9987),
                            ProductName = "IPhone 6s",
                            RefId = new Guid("3579f856-3d62-449b-877b-792f4945b1f9"),
                            StockLevel = 5,
                            UnitPrice = 400m
                        },
                        new
                        {
                            Id = 4L,
                            CreatedBy = 0L,
                            CreatedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9993),
                            Description = "",
                            Featured = false,
                            ModifiedOn = new DateTime(2021, 7, 1, 20, 14, 7, 416, DateTimeKind.Local).AddTicks(9995),
                            ProductName = "OX Fan 10 inch",
                            RefId = new Guid("21970f24-9af8-44c8-a9ee-9084c327bad5"),
                            StockLevel = 15,
                            UnitPrice = 300m
                        });
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.ProductReview", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumOfStars")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReviewBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId1");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.ShoppingCart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<decimal>("CartTotal")
                        .HasColumnType("decimal(10,2)");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserProfileId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId")
                        .IsUnique();

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.UserProfile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long?>("ShoppingCartId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ShoppingCartId1")
                        .HasColumnType("bigint");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserWalletId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserWalletId1")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ShoppingCartId1");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.HasIndex("UserWalletId1");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.UserWallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(10,2)");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RefId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserProfileId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId")
                        .IsUnique();

                    b.ToTable("UserWallets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Walkabouts.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.OrderItem", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.ShoppingCart", null)
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartId");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.PaymentOption", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.UserWallet", null)
                        .WithMany("PaymentOptions")
                        .HasForeignKey("UserWalletId");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.ProductReview", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId1");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.ShoppingCart", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.UserProfile", "UserProfile")
                        .WithOne()
                        .HasForeignKey("Walkabouts.Data.Domain.ShoppingCart", "UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.UserProfile", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartId1");

                    b.HasOne("Walkabouts.Data.Domain.AppUser", "AppUser")
                        .WithOne("UserProfile")
                        .HasForeignKey("Walkabouts.Data.Domain.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Walkabouts.Data.Domain.UserWallet", "UserWallet")
                        .WithMany()
                        .HasForeignKey("UserWalletId1");

                    b.Navigation("AppUser");

                    b.Navigation("ShoppingCart");

                    b.Navigation("UserWallet");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.UserWallet", b =>
                {
                    b.HasOne("Walkabouts.Data.Domain.UserProfile", "UserProfile")
                        .WithOne()
                        .HasForeignKey("Walkabouts.Data.Domain.UserWallet", "UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.AppUser", b =>
                {
                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.Product", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartItems");
                });

            modelBuilder.Entity("Walkabouts.Data.Domain.UserWallet", b =>
                {
                    b.Navigation("PaymentOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
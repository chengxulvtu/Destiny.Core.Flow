﻿// <auto-generated />
using System;
using Destiny.Core.Flow;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Destiny.Core.Flow.Model.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Destiny.Core.Flow.Model.Entities.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModifierTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(10) CHARACTER SET utf8mb4")
                        .HasMaxLength(10);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8551e97-0723-47fc-bd7e-aff35bb1b1e7"),
                            ConcurrencyStamp = "dfcef156-19d3-435c-aa8b-8351f87b2e11",
                            CreatedTime = new DateTime(2020, 3, 29, 14, 14, 52, 377, DateTimeKind.Local).AddTicks(3376),
                            CreatorUserId = new Guid("a1e89f45-4fa8-4751-9df9-dec86f7e6c14"),
                            Description = "拥有系统上所有有权限请不要删除!",
                            IsAdmin = true,
                            IsDeleted = false,
                            Name = "系统管理员",
                            NormalizedName = "系统管理员"
                        });
                });

            modelBuilder.Entity("Destiny.Core.Flow.Model.Entities.Identity.RoleClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ClaimType")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("ClaimValue")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModifierTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaim");
                });

            modelBuilder.Entity("Destiny.Core.Flow.Model.Entities.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("AccessFailedCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("HeadImg")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsSystem")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModifierTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("LockoutEnabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("NormalizeEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1e89f45-4fa8-4751-9df9-dec86f7e6c14"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0286cab6-8a4a-44ed-9a97-86b0506c65c3",
                            CreatedTime = new DateTime(2020, 3, 29, 14, 14, 52, 401, DateTimeKind.Local).AddTicks(4118),
                            Description = "系统管理员拥有所有权限",
                            EmailConfirmed = false,
                            IsDeleted = false,
                            IsSystem = true,
                            LockoutEnabled = true,
                            NickName = "管理员",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEEPWhHPCHU1i6Z0ayoApKGbPlZUb38RUdJg4QjUcccVhUSto0sRZtLOXfwWUJ+P2Xw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3OWMGQAK5ZTXMSV6OFSGIWWWNIWJ2SX6",
                            Sex = 0,
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Destiny.Core.Flow.Model.Entities.Identity.UserClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModifierTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("UserClaim");
                });

            modelBuilder.Entity("Destiny.Core.Flow.Model.Entities.Identity.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModifierTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Destiny.Core.Flow.Model.Entities.Identity.UserToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorUserId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModifierTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierUserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(450) CHARACTER SET utf8mb4")
                        .HasMaxLength(450);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(450) CHARACTER SET utf8mb4")
                        .HasMaxLength(450);

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("UserToken");
                });
#pragma warning restore 612, 618
        }
    }
}
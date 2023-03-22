﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCash.Data;

#nullable disable

namespace MyCash.Data.Migrations
{
    [DbContext(typeof(MyCashDbContext))]
    partial class MyCashDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyCash.Domain.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8786),
                            Description = "I got my salary",
                            Name = "Salary",
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8789),
                            Description = "gas",
                            Name = "bills",
                            Type = 1
                        });
                });

            modelBuilder.Entity("MyCash.Domain.Entities.ExchangeRateForUSD", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("EUR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RUB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UZS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ExchangeRatesForUSD");
                });

            modelBuilder.Entity("MyCash.Domain.Entities.Expose", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("WalletId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WalletId");

                    b.ToTable("Exposes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1000m,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8767),
                            Description = "Furniture",
                            WalletId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 2000m,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8769),
                            Description = "Salary",
                            WalletId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 2000m,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8770),
                            Description = "Price",
                            WalletId = 2L
                        });
                });

            modelBuilder.Entity("MyCash.Domain.Entities.Income", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("WalletId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WalletId");

                    b.ToTable("Incomes");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1000m,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8745),
                            Description = "Salary",
                            WalletId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 2000m,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8747),
                            Description = "Salary",
                            WalletId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 2000m,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8749),
                            Description = "Price",
                            WalletId = 2L
                        });
                });

            modelBuilder.Entity("MyCash.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8684),
                            Email = "komron2052@gmail.com",
                            FirstName = "Komron",
                            LastName = "Rakhmonov",
                            Password = "12345678"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8690),
                            Email = "ahmadboy@gmail.com",
                            FirstName = "Ahmad",
                            LastName = "jurayev",
                            Password = "87654321"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8691),
                            Email = "shaxmatboyboy@gmail.com",
                            FirstName = "Shaxmat",
                            LastName = "Shashka",
                            Password = "54689135"
                        });
                });

            modelBuilder.Entity("MyCash.Domain.Entities.Wallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Wallets");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 10000m,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8720),
                            Currency = 1,
                            Name = "MyWallet",
                            UserId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 50000m,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8722),
                            Currency = 2,
                            Name = "MyWalletNomber2",
                            UserId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 75000m,
                            CreatedAt = new DateTime(2023, 3, 22, 15, 54, 51, 890, DateTimeKind.Local).AddTicks(8724),
                            Currency = 2,
                            Name = "MyWallet",
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("MyCash.Domain.Entities.Expose", b =>
                {
                    b.HasOne("MyCash.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCash.Domain.Entities.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("MyCash.Domain.Entities.Income", b =>
                {
                    b.HasOne("MyCash.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCash.Domain.Entities.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Wallet");
                });

            modelBuilder.Entity("MyCash.Domain.Entities.Wallet", b =>
                {
                    b.HasOne("MyCash.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}

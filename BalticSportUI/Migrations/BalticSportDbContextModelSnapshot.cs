﻿// <auto-generated />
using System;
using BalticSportAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BalticSportAPI.Migrations
{
    [DbContext(typeof(BalticSportDbContext))]
    partial class BalticSportDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BalticSportAPI.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneID")
                        .HasColumnType("int");

                    b.HasKey("CustomerID");

                    b.HasIndex("PhoneID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BalticSportAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellerID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BalticSportAPI.Models.OrderLine", b =>
                {
                    b.Property<int>("OrderLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("OrderLineID");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("BalticSportAPI.Models.Phone", b =>
                {
                    b.Property<int>("PhoneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhoneNumber1")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber2")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumberOne")
                        .HasColumnType("int");

                    b.HasKey("PhoneID");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("BalticSportAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductPrice")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BalticSportAPI.Models.Seller", b =>
                {
                    b.Property<int>("SellerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerID");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("BalticSportAPI.Models.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.Property<string>("SupplierName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("BalticSportAPI.Models.Customer", b =>
                {
                    b.HasOne("BalticSportAPI.Models.Phone", "Phone")
                        .WithMany()
                        .HasForeignKey("PhoneID");
                });
#pragma warning restore 612, 618
        }
    }
}

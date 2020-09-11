﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TraderApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.StockDetail", b =>
                {
                    b.Property<int>("StockID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("StockID");

                    b.ToTable("StockDetails");
                });

            modelBuilder.Entity("DAL.Entities.StockTransaction", b =>
                {
                    b.Property<int>("StockTransactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockDetailID")
                        .HasColumnType("int");

                    b.Property<string>("TrasnactionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserDetailID")
                        .HasColumnType("int");

                    b.Property<float>("UserStockPrice")
                        .HasColumnType("real");

                    b.Property<int>("UserStockQuantity")
                        .HasColumnType("int");

                    b.HasKey("StockTransactionID");

                    b.HasIndex("StockDetailID");

                    b.HasIndex("UserDetailID");

                    b.ToTable("StockTransactions");
                });

            modelBuilder.Entity("DAL.Entities.UserDetail", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("DAL.Entities.StockTransaction", b =>
                {
                    b.HasOne("DAL.Entities.StockDetail", "StockDetail")
                        .WithMany()
                        .HasForeignKey("StockDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.UserDetail", "UserDetail")
                        .WithMany()
                        .HasForeignKey("UserDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

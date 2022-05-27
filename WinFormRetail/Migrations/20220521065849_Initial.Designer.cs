﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormRetail.Data;

#nullable disable

namespace WinFormRetail.Migrations
{
    [DbContext(typeof(CashireDbContext))]
    [Migration("20220521065849_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("WinFormRetail.Model.Product", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WinFormRetail.Model.Transaction", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("UsersID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("WinFormRetail.Model.TransactionProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TransactionID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("TransactionID");

                    b.ToTable("TransactionProducts");
                });

            modelBuilder.Entity("WinFormRetail.Model.User", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WinFormRetail.Model.Transaction", b =>
                {
                    b.HasOne("WinFormRetail.Model.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersID");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WinFormRetail.Model.TransactionProduct", b =>
                {
                    b.HasOne("WinFormRetail.Model.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WinFormRetail.Model.Transaction", "Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionID");

                    b.Navigation("Product");

                    b.Navigation("Transaction");
                });
#pragma warning restore 612, 618
        }
    }
}
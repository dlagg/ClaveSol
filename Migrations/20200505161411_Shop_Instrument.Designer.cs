﻿// <auto-generated />
using System;
using ClaveSol.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClaveSol.Migrations
{
    [DbContext(typeof(ClaveSolDbContext))]
    [Migration("20200505161411_Shop_Instrument")]
    partial class Shop_Instrument
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("ClaveSol.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ClaveSol.Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Resolved")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OperatorId");

                    b.HasIndex("UserId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("ClaveSol.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Stars")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InstrumentId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("ClaveSol.Models.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LineOrderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MediaDir")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SubCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("shInsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LineOrderId")
                        .IsUnique();

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Instrument");
                });

            modelBuilder.Entity("ClaveSol.Models.LineOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("IntrumentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitaryPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("LineOrder");
                });

            modelBuilder.Entity("ClaveSol.Models.List", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ListId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("List");
                });

            modelBuilder.Entity("ClaveSol.Models.List_Instrument", b =>
                {
                    b.Property<int>("ListId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ListId", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("List_Instrument");
                });

            modelBuilder.Entity("ClaveSol.Models.Operator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Operator");
                });

            modelBuilder.Entity("ClaveSol.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("nLines")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ClaveSol.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ShopId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Shop");
                });

            modelBuilder.Entity("ClaveSol.Models.Shop_Ins", b =>
                {
                    b.Property<int>("ShopId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstrumentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ShopId", "InstrumentId");

                    b.HasIndex("InstrumentId");

                    b.ToTable("Shop_Ins");
                });

            modelBuilder.Entity("ClaveSol.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("ClaveSol.Models.Tiket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("OperatorId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("OperatorId");

                    b.HasIndex("OrderId");

                    b.ToTable("Tiket");
                });

            modelBuilder.Entity("ClaveSol.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(30);

                    b.Property<string>("OwnerID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Premium")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ClaveSol.Models.Chat", b =>
                {
                    b.HasOne("ClaveSol.Models.Operator", "Operator")
                        .WithMany("Chats")
                        .HasForeignKey("OperatorId");

                    b.HasOne("ClaveSol.Models.User", "User")
                        .WithMany("Chats")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ClaveSol.Models.Comment", b =>
                {
                    b.HasOne("ClaveSol.Models.Instrument", "Instrument")
                        .WithMany("Comments")
                        .HasForeignKey("InstrumentId");

                    b.HasOne("ClaveSol.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ClaveSol.Models.Instrument", b =>
                {
                    b.HasOne("ClaveSol.Models.LineOrder", "LineOrder")
                        .WithOne("Instrument")
                        .HasForeignKey("ClaveSol.Models.Instrument", "LineOrderId");

                    b.HasOne("ClaveSol.Models.SubCategory", "SubCategory")
                        .WithMany("Instrument")
                        .HasForeignKey("SubCategoryId");
                });

            modelBuilder.Entity("ClaveSol.Models.LineOrder", b =>
                {
                    b.HasOne("ClaveSol.Models.Order", "Order")
                        .WithMany("LineOrders")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("ClaveSol.Models.List", b =>
                {
                    b.HasOne("ClaveSol.Models.User", "User")
                        .WithMany("Lists")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ClaveSol.Models.List_Instrument", b =>
                {
                    b.HasOne("ClaveSol.Models.Instrument", "Instrument")
                        .WithMany("List_Instruments")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClaveSol.Models.List", "List")
                        .WithMany("List_Instruments")
                        .HasForeignKey("ListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClaveSol.Models.Order", b =>
                {
                    b.HasOne("ClaveSol.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ClaveSol.Models.Shop_Ins", b =>
                {
                    b.HasOne("ClaveSol.Models.Instrument", "Instrument")
                        .WithMany("Shop_Inss")
                        .HasForeignKey("InstrumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClaveSol.Models.Shop", "Shop")
                        .WithMany("Shop_Inss")
                        .HasForeignKey("ShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClaveSol.Models.SubCategory", b =>
                {
                    b.HasOne("ClaveSol.Models.Category", "Category")
                        .WithMany("SubCategory")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("ClaveSol.Models.Tiket", b =>
                {
                    b.HasOne("ClaveSol.Models.Operator", "Operator")
                        .WithMany("Tikets")
                        .HasForeignKey("OperatorId");

                    b.HasOne("ClaveSol.Models.Order", "Order")
                        .WithMany("Tikets")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}

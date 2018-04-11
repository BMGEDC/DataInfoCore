﻿// <auto-generated />
using DataInfoCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DataInfoCore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180411115616_addwinfo")]
    partial class addwinfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataInfoCore.Models.Communication", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CommDate");

                    b.Property<string>("CommText")
                        .HasMaxLength(64000);

                    b.Property<int>("ContactID");

                    b.HasKey("ID");

                    b.ToTable("Communication");
                });

            modelBuilder.Entity("DataInfoCore.Models.Config", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("DataPeriod")
                        .HasMaxLength(1);

                    b.Property<DateTime?>("DataProcessed");

                    b.Property<DateTime?>("DataRecieved");

                    b.Property<DateTime?>("DataUploaded");

                    b.Property<string>("ExternalProcess");

                    b.Property<string>("Function")
                        .HasMaxLength(1);

                    b.Property<int>("MarketID");

                    b.Property<DateTime?>("PagesApproved");

                    b.Property<DateTime?>("ProcessEndTIme");

                    b.Property<DateTime?>("ProcessStartTime");

                    b.Property<DateTime?>("ProofSent");

                    b.Property<string>("Summary");

                    b.Property<int>("WholesalerID");

                    b.HasKey("ID");

                    b.HasIndex("MarketID");

                    b.HasIndex("WholesalerID");

                    b.ToTable("Config");
                });

            modelBuilder.Entity("DataInfoCore.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EMail");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.Property<int>("WholesalerID");

                    b.HasKey("Id");

                    b.HasIndex("WholesalerID");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("DataInfoCore.Models.ContactRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactId");

                    b.Property<int>("RoleId");

                    b.Property<int>("WholesalerId");

                    b.HasKey("ID");

                    b.ToTable("ContactRole");
                });

            modelBuilder.Entity("DataInfoCore.Models.Market", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Eorders")
                        .HasMaxLength(1);

                    b.Property<string>("MarketCode")
                        .HasMaxLength(6);

                    b.Property<string>("MarketName")
                        .HasMaxLength(100);

                    b.Property<string>("Status")
                        .HasMaxLength(1);

                    b.Property<int>("sort");

                    b.HasKey("ID");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("DataInfoCore.Models.Processlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("ConfigID");

                    b.Property<DateTime>("Logdate");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.ToTable("Processlog");
                });

            modelBuilder.Entity("DataInfoCore.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleDescription")
                        .HasMaxLength(40);

                    b.HasKey("ID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DataInfoCore.Models.Wholesaler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<bool>("CustomerFeed");

                    b.Property<bool>("DailyFeed");

                    b.Property<string>("ETSLocation");

                    b.Property<bool>("ETSUser");

                    b.Property<bool>("InBook");

                    b.Property<int>("MarketID");

                    b.Property<bool>("Online");

                    b.Property<string>("Price_Zone")
                        .HasMaxLength(3);

                    b.Property<string>("WholesalerCode")
                        .HasMaxLength(6);

                    b.Property<string>("WholesalerName");

                    b.Property<string>("bm_id")
                        .HasMaxLength(10);

                    b.Property<string>("org_id")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.HasIndex("MarketID");

                    b.ToTable("Wholesaler");
                });

            modelBuilder.Entity("DataInfoCore.Models.Config", b =>
                {
                    b.HasOne("DataInfoCore.Models.Market", "Market")
                        .WithMany()
                        .HasForeignKey("MarketID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataInfoCore.Models.Wholesaler", "Wholesaler")
                        .WithMany()
                        .HasForeignKey("WholesalerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataInfoCore.Models.Contact", b =>
                {
                    b.HasOne("DataInfoCore.Models.Wholesaler", "Wholesaler")
                        .WithMany()
                        .HasForeignKey("WholesalerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataInfoCore.Models.Wholesaler", b =>
                {
                    b.HasOne("DataInfoCore.Models.Market", "Market")
                        .WithMany()
                        .HasForeignKey("MarketID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

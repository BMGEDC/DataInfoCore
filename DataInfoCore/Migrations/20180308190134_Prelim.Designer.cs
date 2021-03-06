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
    [Migration("20180308190134_Prelim")]
    partial class Prelim
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataInfoCore.Models.Market", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MarketCode")
                        .HasMaxLength(6);

                    b.Property<string>("MarketName");

                    b.Property<string>("Status")
                        .HasMaxLength(1);

                    b.HasKey("ID");

                    b.ToTable("Market");
                });
#pragma warning restore 612, 618
        }
    }
}

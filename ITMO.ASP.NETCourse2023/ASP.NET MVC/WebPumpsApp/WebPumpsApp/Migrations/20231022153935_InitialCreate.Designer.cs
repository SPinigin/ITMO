﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebPumpsApp.Data;

#nullable disable

namespace WebPumpsApp.Migrations
{
    [DbContext(typeof(PumpsContext))]
    [Migration("20231022153935_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebPumpsApp.Models.Bid", b =>
                {
                    b.Property<int>("BidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BidId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PumpHead")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("bidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BidId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("WebPumpsApp.Models.Pump", b =>
                {
                    b.Property<int>("PumpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PumpId"), 1L, 1);

                    b.Property<int>("Flow")
                        .HasColumnType("int");

                    b.Property<string>("Head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IntDiam")
                        .HasColumnType("int");

                    b.Property<int>("OutdDiam")
                        .HasColumnType("int");

                    b.Property<double>("Power")
                        .HasColumnType("float");

                    b.Property<int>("Pressure")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("PumpId");

                    b.ToTable("Pumps");
                });
#pragma warning restore 612, 618
        }
    }
}

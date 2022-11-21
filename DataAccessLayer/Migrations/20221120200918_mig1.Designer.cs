﻿// <auto-generated />
using DataAccessLayer.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(HospitalProject))]
    [Migration("20221120200918_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityLayer.Concrete.Reports", b =>
                {
                    b.Property<int>("reportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reportId"));

                    b.Property<string>("reportdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reportname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("reportId");

                    b.ToTable("reports");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Reservations", b =>
                {
                    b.Property<int>("reservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("reservationId"));

                    b.Property<string>("reservationdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reservationname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("reservationId");

                    b.ToTable("reservations");
                });
#pragma warning restore 612, 618
        }
    }
}

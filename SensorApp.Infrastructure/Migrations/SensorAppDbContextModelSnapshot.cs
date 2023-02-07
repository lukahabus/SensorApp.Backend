﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SensorApp.Infrastructure;

#nullable disable

namespace SensorApp.Infrastructure.Migrations
{
    [DbContext(typeof(SensorAppDbContext))]
    partial class SensorAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SensorApp.Core.Entities.Sensor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<float>("Humidity")
                        .HasColumnType("real");

                    b.Property<float>("Light")
                        .HasColumnType("real");

                    b.Property<string>("SensorType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sensors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Humidity = 1f,
                            Light = 1f,
                            SensorType = "Temperature",
                            Temperature = 1f
                        },
                        new
                        {
                            Id = 2L,
                            Humidity = 22f,
                            Light = 10f,
                            SensorType = "Humidity",
                            Temperature = 31f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
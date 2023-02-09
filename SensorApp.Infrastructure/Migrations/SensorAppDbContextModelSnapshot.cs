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

                    b.Property<int>("RangeEnd")
                        .HasColumnType("int");

                    b.Property<int>("RangeStart")
                        .HasColumnType("int");

                    b.Property<string>("SensorType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sensors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 608355f
                        },
                        new
                        {
                            Id = 2L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 345f
                        },
                        new
                        {
                            Id = 3L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 85f
                        },
                        new
                        {
                            Id = 4L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 62f
                        },
                        new
                        {
                            Id = 5L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 96f
                        },
                        new
                        {
                            Id = 6L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -163f
                        },
                        new
                        {
                            Id = 7L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 992379f
                        },
                        new
                        {
                            Id = 8L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 6f
                        },
                        new
                        {
                            Id = 9L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 12f
                        },
                        new
                        {
                            Id = 10L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 81f
                        },
                        new
                        {
                            Id = 11L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 58f
                        },
                        new
                        {
                            Id = 12L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 74f
                        },
                        new
                        {
                            Id = 13L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 459f
                        },
                        new
                        {
                            Id = 14L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 97f
                        },
                        new
                        {
                            Id = 15L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 565f
                        },
                        new
                        {
                            Id = 16L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 58f
                        },
                        new
                        {
                            Id = 17L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 33f
                        },
                        new
                        {
                            Id = 18L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 707947f
                        },
                        new
                        {
                            Id = 19L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 263455f
                        },
                        new
                        {
                            Id = 20L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 81f
                        },
                        new
                        {
                            Id = 21L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -120f
                        },
                        new
                        {
                            Id = 22L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 50735f
                        },
                        new
                        {
                            Id = 23L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 63f
                        },
                        new
                        {
                            Id = 24L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 39f
                        },
                        new
                        {
                            Id = 25L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 41f
                        },
                        new
                        {
                            Id = 26L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 60f
                        },
                        new
                        {
                            Id = 27L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 12f
                        },
                        new
                        {
                            Id = 28L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 418980f
                        },
                        new
                        {
                            Id = 29L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 22f
                        },
                        new
                        {
                            Id = 30L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 254f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

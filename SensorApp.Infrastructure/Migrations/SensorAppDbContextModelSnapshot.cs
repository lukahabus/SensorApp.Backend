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
                            Id = 8843L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 51f
                        },
                        new
                        {
                            Id = 9691L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -192f
                        },
                        new
                        {
                            Id = 4411L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 766701f
                        },
                        new
                        {
                            Id = 1227L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 920220f
                        },
                        new
                        {
                            Id = 2043L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 82f
                        },
                        new
                        {
                            Id = 8768L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 5f
                        },
                        new
                        {
                            Id = 8255L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 786735f
                        },
                        new
                        {
                            Id = 6662L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 435698f
                        },
                        new
                        {
                            Id = 7498L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 656384f
                        },
                        new
                        {
                            Id = 8742L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 173f
                        },
                        new
                        {
                            Id = 2994L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 91f
                        },
                        new
                        {
                            Id = 1991L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 444195f
                        },
                        new
                        {
                            Id = 8087L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -90f
                        },
                        new
                        {
                            Id = 1107L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 314554f
                        },
                        new
                        {
                            Id = 7565L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 254401f
                        },
                        new
                        {
                            Id = 1421L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 89f
                        },
                        new
                        {
                            Id = 8711L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 913081f
                        },
                        new
                        {
                            Id = 9032L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 728076f
                        },
                        new
                        {
                            Id = 7196L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 621f
                        },
                        new
                        {
                            Id = 2223L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 714229f
                        },
                        new
                        {
                            Id = 5179L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -195f
                        },
                        new
                        {
                            Id = 2666L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -96f
                        },
                        new
                        {
                            Id = 1889L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 90f
                        },
                        new
                        {
                            Id = 5896L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 772492f
                        },
                        new
                        {
                            Id = 4776L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 967743f
                        },
                        new
                        {
                            Id = 9683L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 59f
                        },
                        new
                        {
                            Id = 5697L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 145f
                        },
                        new
                        {
                            Id = 6740L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 413739f
                        },
                        new
                        {
                            Id = 9312L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -197f
                        },
                        new
                        {
                            Id = 6643L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 519022f
                        },
                        new
                        {
                            Id = 7044L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = -76f
                        },
                        new
                        {
                            Id = 1302L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 68f
                        },
                        new
                        {
                            Id = 1638L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 599353f
                        },
                        new
                        {
                            Id = 8147L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 41f
                        },
                        new
                        {
                            Id = 6258L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 0f
                        },
                        new
                        {
                            Id = 1396L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 71f
                        },
                        new
                        {
                            Id = 5953L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 21f
                        },
                        new
                        {
                            Id = 9707L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 21f
                        },
                        new
                        {
                            Id = 2908L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 57f
                        },
                        new
                        {
                            Id = 4096L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 859618f
                        },
                        new
                        {
                            Id = 1526L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 402113f
                        },
                        new
                        {
                            Id = 6146L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 9f
                        },
                        new
                        {
                            Id = 5287L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 898754f
                        },
                        new
                        {
                            Id = 9027L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 26f
                        },
                        new
                        {
                            Id = 7682L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 570066f
                        },
                        new
                        {
                            Id = 2596L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 260f
                        },
                        new
                        {
                            Id = 6922L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 39f
                        },
                        new
                        {
                            Id = 1591L,
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 21f
                        },
                        new
                        {
                            Id = 9646L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 52203f
                        },
                        new
                        {
                            Id = 5315L,
                            RangeEnd = 1000000,
                            RangeStart = 0,
                            SensorType = "Light",
                            Value = 311194f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

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
                            RangeEnd = 650,
                            RangeStart = -240,
                            SensorType = "Temperature",
                            Value = 200f
                        },
                        new
                        {
                            Id = 2L,
                            RangeEnd = 100,
                            RangeStart = 0,
                            SensorType = "Humidity",
                            Value = 30f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

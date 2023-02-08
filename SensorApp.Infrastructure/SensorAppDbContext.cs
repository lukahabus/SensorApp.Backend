using SensorApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorApp.Infrastructure
{
    public class SensorAppDbContext : DbContext
    {
        public SensorAppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Sensor> Sensors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sensor>().HasData(
                new Sensor(1, "Temperature", 200));

            modelBuilder.Entity<Sensor>().HasData(
                new Sensor(2, "Humidity", 30));

            modelBuilder.Entity<Sensor>().HasData(
                new Sensor(3, "Light", 450));
        }
    }
}

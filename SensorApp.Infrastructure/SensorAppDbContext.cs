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
            string[] SensorTypes = { "Temperature", "Humidity", "Light" };
            int[] RangeStart = { -240, 0, 0 };
            int[] RangeEnd = { 650, 100, 1000000 };

            Random rd = new Random();

            for (int i = 0; i < 50; i++)
            {
                int T = rd.Next() % 3;
                modelBuilder.Entity<Sensor>().HasData(
                    new Sensor(rd.Next(1000, 9999), SensorTypes[T], rd.Next(RangeStart[T], RangeEnd[T])));
            }
        }
    }
}

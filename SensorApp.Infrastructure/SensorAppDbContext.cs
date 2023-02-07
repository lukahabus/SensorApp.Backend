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

        //protected override void onModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Sensor>().HasData(
        //        new Sensor
        //        {
        //            Id= 1,
        //            Humidity = 1,
        //            Light = 1,
        //            Temperature = 1
        //        });
        //}
    }
}

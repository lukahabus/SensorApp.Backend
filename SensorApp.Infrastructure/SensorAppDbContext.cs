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

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace SensorApp.Core.Entities
{
    public class Sensor
    {
        public long Id { get; set; }

        public float Humidity { get; set; }

        public float Light { get; set; }

        public float Temperature { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace SensorApp.Core.Entities
{
    //public enum SensorType
    //{
    //    Humidity,
    //    Light,
    //    Temperature
    //}

    public class Sensor
    {
        public long Id { get; set; }

        public float Humidity { get; set; }

        public float Light { get; set; }

        public float Temperature { get; set; }

        public float TemperatureF => (float)(32 + (Temperature / 0.5556));

        //public SensorType SensorType { get; set; }

        public string SensorType { get; set; }
    }
}

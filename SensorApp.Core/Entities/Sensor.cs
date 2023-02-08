using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable

namespace SensorApp.Core.Entities
{   public class Sensor
    {
        public long Id { get; set; }

        //public SensorType SensorType { get; set; }

        public string SensorType { get; set; }

        public int RangeStart { get; set; }

        public int RangeEnd { get; set; }

        public float Value { get; set; }

        public Sensor(long Id, string SensorType, float Value) { 
            this.Id = Id;
            this.SensorType = SensorType;
            if(SensorType == null) throw new ArgumentNullException(nameof(SensorType));
            else if (SensorType.Equals("Humidity")) 
            {  
                RangeStart = 0; 
                RangeEnd = 100;
                if(Value >= RangeStart && Value <= RangeEnd) { 
                    this.Value = Value;
                }
                else throw new ArgumentOutOfRangeException(nameof(Value));
                
            }
            else if (SensorType.Equals("Light")) 
            { 
                RangeStart = 0; 
                RangeEnd = 1000000;
                if (Value >= RangeStart && Value <= RangeEnd)
                {
                    this.Value = Value;
                }
                else throw new ArgumentOutOfRangeException(nameof(Value));
            }
            else if (SensorType.Equals("Temperature")) 
            { 
                RangeStart = -240; 
                RangeEnd = 650;
                if (Value >= RangeStart && Value <= RangeEnd)
                {
                    this.Value = Value;
                }
                else throw new ArgumentOutOfRangeException(nameof(Value));
            }
            else throw new ArgumentException("There is no " + SensorType + " Sensor");
        }

        public void changeRange(int RangeStart, int RangeEnd)
        {
            this.RangeStart = RangeStart;
            this.RangeEnd = RangeEnd;
        }
    }
}

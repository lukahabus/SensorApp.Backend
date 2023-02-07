using SensorApp.Core.Entities;

namespace SensorApp.API.Models
{
    public record SensorModel(
        long Id,
        float Humidity,
        float Light,
        float Temperature,
        float TemperatureF,
        string SensorType
     );
}

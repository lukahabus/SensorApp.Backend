using SensorApp.Core.Entities;

namespace SensorApp.API.Models
{
    public record SensorModel(
        long Id,
        string SensorType,
        int RangeStart,
        int RangeEnd,
        float Value
     );

    public record DropdownModel(
        long Id,
        string SensorType,
        float Value
     );
}

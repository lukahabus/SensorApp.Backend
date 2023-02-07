using SensorApp.API.Models;
using SensorApp.Core.Entities;
using SensorApp.Infrastructure;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace SensorApp.API.Controllers
{
    [Route("api/sensors")]
    [ApiController]
    public class SensorsController : ControllerBase
    {
        private readonly SensorAppDbContext _dbContext;

        public SensorsController(SensorAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<SensorModel>>> GetSensors()
        {
            var sensors = await _dbContext.Sensors.Select(x => new SensorModel(x.Id, x.Humidity, x.Light, x.Temperature, x.TemperatureF, x.SensorType)).ToListAsync();
            
            return Ok(sensors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SensorModel>> GetSensor(long id)
        {
            var sensor = await _dbContext.Sensors.FirstOrDefaultAsync(x => x.Id == id);
            if (sensor is null)
                return BadRequest("Sensor doesn't exist");

            return Ok(new SensorModel(sensor.Id, sensor.Humidity, sensor.Light, sensor.Temperature, sensor.TemperatureF, sensor.SensorType));
        }
    }
}

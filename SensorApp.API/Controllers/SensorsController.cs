using SensorApp.API.Models;
using SensorApp.Core.Entities;
using SensorApp.Infrastructure;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore.Infrastructure;

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
            var sensors = await _dbContext.Sensors.Select(x => new SensorModel(x.Id, x.SensorType, x.RangeStart, x.RangeEnd, x.Value)).ToListAsync();
            
            return Ok(sensors);
        }

        [HttpGet("dropdown")]
        public async Task<ActionResult<List<DropdownModel>>> GetSensorsDropdown()
        {
            var sensorsDropdown = await _dbContext.Sensors.Select(x => new DropdownModel(x.Id, x.SensorType, x.Value)).ToListAsync();

            return Ok(sensorsDropdown);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SensorModel>> GetSensor(long id)
        {
            var sensor = await _dbContext.Sensors.FirstOrDefaultAsync(x => x.Id == id);
            if (sensor is null)
                return BadRequest("Sensor doesn't exist");

            return Ok(new SensorModel(sensor.Id, sensor.SensorType, sensor.RangeStart, sensor.RangeEnd, sensor.Value));
        }

        [HttpPut]
        public async Task<ActionResult<SensorModel>> UpdateSensor([FromBody] SensorModel sensorModel)
        {
            var sensor = await _dbContext.Sensors.FirstOrDefaultAsync(x => x.Id == sensorModel.Id);
            if (sensor is null)
                return BadRequest("Sensor doesn't exist");

            sensor.SensorType = sensorModel.SensorType;
            sensor.RangeStart = sensorModel.RangeStart;
            sensor.RangeEnd = sensorModel.RangeEnd;
            sensor.Value = sensorModel.Value;

            _dbContext.Entry(sensor).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return Ok(sensorModel);
        }

        [HttpPost]
        public async Task<ActionResult<SensorModel>> AddSensor([FromBody] SensorModel sensorModel)
        {
            var sensor = new Sensor(sensorModel.Id, sensorModel.SensorType, sensorModel.Value);
            sensor.changeRange(sensorModel.RangeStart, sensorModel.RangeEnd);

            _dbContext.Sensors.Add(sensor);

            await _dbContext.SaveChangesAsync();

            return Ok(new SensorModel(sensor.Id, sensor.SensorType, sensor.RangeStart, sensor.RangeEnd, sensor.Value));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SensorModel>> DeleteSensor(long id)
        {
            var sensor = await _dbContext.Sensors.FirstOrDefaultAsync(x => x.Id == id);
            if (sensor is null)
                return BadRequest("Sensor doesn't exist");
            else
            {
                _dbContext.Sensors.Remove(sensor);
            }
            await _dbContext.SaveChangesAsync();

            return Ok(sensor);
        }
    }
}

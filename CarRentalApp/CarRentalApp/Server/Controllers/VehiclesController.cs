using Microsoft.AspNetCore.Mvc;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            var models = await _unitOfWork.Vehicles.GetAllAsync();

            return Ok(models);
        }

        // GET: api/Vehicles/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetVehicle(int id)
        {
            var model = await _unitOfWork.Vehicles.Get(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Vehicles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Vehicles.Update(vehicle);

            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (Exception ex)
            {
                if (!await VehicleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Vehicles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostVehicle([FromBody] Vehicle vehicle)
        {
            await _unitOfWork.Vehicles.Insert(vehicle);

            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetVehicle", new { id = vehicle.Id }, vehicle);
        }

        // DELETE: api/Vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var model = await _unitOfWork.Vehicles.Get(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Vehicles.Delete(id);

            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> VehicleExists(int id)
        {
            var model = await _unitOfWork.Vehicles.Get(x => x.Id == id);

            return model != null;
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<IActionResult> GetBookings()
        {
            var models = await _unitOfWork.Bookings.GetAllAsync();

            return Ok(models);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetBooking(int id)
        {
            var model = await _unitOfWork.Bookings.Get(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBooking(int id, Booking booking)
        {
            if (id != booking.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Bookings.Update(booking);

            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (Exception ex)
            {
                if (!await BookingExists(id))
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

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostBooking([FromBody] Booking booking)
        {
            await _unitOfWork.Bookings.Insert(booking);

            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetBooking", new { id = booking.Id }, booking);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookings(int id)
        {
            var model = await _unitOfWork.Bookings.Get(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Bookings.Delete(id);

            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> BookingExists(int id)
        {
            var model = await _unitOfWork.Bookings.Get(x => x.Id == id);

            return model != null;
        }
    }
}

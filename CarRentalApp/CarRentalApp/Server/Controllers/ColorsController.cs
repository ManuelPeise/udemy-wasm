using Microsoft.AspNetCore.Mvc;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Colors
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var models = await _unitOfWork.Colors.GetAllAsync();

            return Ok(models);
        }

        // GET: api/Colors/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetColor(int id)
        {
            var model = await _unitOfWork.Colors.Get(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Colors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color Color)
        {
            if (id != Color.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Colors.Update(Color);

            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (Exception ex)
            {
                if (!await ColorExists(id))
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

        // POST: api/Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostColor([FromBody] Color Color)
        {
            await _unitOfWork.Colors.Insert(Color);

            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetColor", new { id = Color.Id }, Color);
        }

        // DELETE: api/Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var model = await _unitOfWork.Colors.Get(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Colors.Delete(id);

            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> ColorExists(int id)
        {
            var model = await _unitOfWork.Colors.Get(x => x.Id == id);

            return model != null;
        }
    }
}

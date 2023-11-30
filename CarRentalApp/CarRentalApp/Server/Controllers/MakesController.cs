using Microsoft.AspNetCore.Mvc;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            var models = await _unitOfWork.Makes.GetAllAsync();

            return Ok(models);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetMake(int id)
        {
            var model = await _unitOfWork.Makes.Get(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Makes.Update(make);

            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (Exception ex)
            {
                if (!await MakeExists(id))
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
        public async Task<ActionResult> PostMake([FromBody]Make make)
        {
            await _unitOfWork.Makes.Insert(make);

            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            var model = await _unitOfWork.Makes.Get(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Makes.Delete(id);

            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var model = await _unitOfWork.Makes.Get(x => x.Id == id);

            return model != null;
        }
    }
}

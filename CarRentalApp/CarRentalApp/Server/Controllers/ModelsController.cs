using Microsoft.AspNetCore.Mvc;
using CarRentalApp.Shared.Domain;
using CarRentalApp.Server.IRepository;

namespace CarRentalApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Models
        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            var models = await _unitOfWork.Models.GetAllAsync();

            return Ok(models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetModel(int id)
        {
            var model = await _unitOfWork.Models.Get(x => x.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Models.Update(model);

            try
            {
                await _unitOfWork.Save(this.HttpContext);

            }
            catch (Exception ex)
            {
                if (!await ModelExists(id))
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

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> PostModel([FromBody] Model model)
        {
            await _unitOfWork.Models.Insert(model);

            await _unitOfWork.Save(this.HttpContext);

            return CreatedAtAction("GetModel", new { id = model.Id }, model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var model = await _unitOfWork.Models.Get(x => x.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            await _unitOfWork.Models.Delete(id);

            await _unitOfWork.Save(this.HttpContext);

            return NoContent();
        }

        private async Task<bool> ModelExists(int id)
        {
            var model = await _unitOfWork.Models.Get(x => x.Id == id);

            return model != null;
        }
    }
}

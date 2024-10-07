using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class HeadqueartersController : ControllerBase
    {
        private readonly IHeadqueartersService _headqueartersService;

        public HeadqueartersController(IHeadqueartersService headqueartersService)
        {
            _headqueartersService = headqueartersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Headquearters>>> GetAll()
        {
            var headquearters = await _headqueartersService.GetAll();
            return Ok(headquearters);
        }

        [HttpGet("{HEADQ_ID}")]
        public async Task<ActionResult<Headquearters>> GetHeadquearter(int HEADQ_ID)
        {
            var headquarter = await _headqueartersService.GetHeadquearter(HEADQ_ID);
            if (headquarter == null)
            {
                return NotFound("Headquarter not found");
            }
            return Ok(headquarter);
        }

        [HttpPost]
        public async Task<ActionResult<Headquearters>> CreateHeadquearter([FromBody] Headquearters headquarter)
        {
            if (headquarter == null)
            {
                return BadRequest("Headquarter cannot be created");
            }

            var createdHeadquarter = await _headqueartersService.CreateHeadquearter(headquarter);
            return CreatedAtAction(nameof(GetHeadquearter), new { HEADQ_ID = createdHeadquarter.HEADQ_ID }, createdHeadquarter);
        }

        [HttpPut("{HEADQ_ID}")]
        public async Task<ActionResult<Headquearters>> UpdateHeadquearter(int HEADQ_ID, [FromBody] Headquearters headquarter)
        {
            if (headquarter == null || headquarter.HEADQ_ID != HEADQ_ID)
            {
                return BadRequest("Headquarter cannot be updated");
            }

            var updatedHeadquarter = await _headqueartersService.UpdateHeadquearter(headquarter);
            if (updatedHeadquarter == null)
            {
                return NotFound("Headquarter not found");
            }

            return Ok(updatedHeadquarter);
        }

        [HttpDelete("{HEADQ_ID}")]
        public async Task<ActionResult> DeleteHeadquearter(int HEADQ_ID)
        {
            var deletedHeadquarter = await _headqueartersService.DeleteHeadquearter(HEADQ_ID);
            if (deletedHeadquarter == null)
            {
                return NotFound("Headquarter not found");
            }
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class SpecialitiesController : ControllerBase
    {
        private readonly ISpecialitiesService _specialitiesService;

        public SpecialitiesController(ISpecialitiesService specialitiesService)
        {
            _specialitiesService = specialitiesService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Specialities>>> GetAll()
        {
            var specialities = await _specialitiesService.GetAll();
            return Ok(specialities);
        }

        [HttpGet("{SPEC_ID}")]
        public async Task<ActionResult<Specialities>> GetSpecialitie(int SPEC_ID)
        {
            var Specialities = await _specialitiesService.GetSpecialitie(SPEC_ID);
            if (Specialities == null)
            {
                return NotFound("Specialities not found");
            }
            return Ok(Specialities);
        }

        [HttpPost]
        public async Task<ActionResult<Specialities>> CreateSpecialitie([FromBody] Specialities Specialities)
        {
            if (Specialities == null)
            {
                return BadRequest("Specialities cannot be created");
            }

            var createdSpecialities = await _specialitiesService.CreateSpecialitie(Specialities);
            return CreatedAtAction(nameof(GetSpecialitie), new { SPEC_ID = createdSpecialities.SPEC_ID }, createdSpecialities);
        }

        [HttpPut("{SPEC_ID}")]
        public async Task<ActionResult<Specialities>> UpdateSpecialitie(int SPEC_ID, [FromBody] Specialities Specialities)
        {
            if (Specialities == null || Specialities.SPEC_ID != SPEC_ID)
            {
                return BadRequest("Specialities cannot be updated");
            }

            var updatedSpecialities = await _specialitiesService.UpdateSpecialitie(Specialities);
            if (updatedSpecialities == null)
            {
                return NotFound("Specialities not found");
            }

            return Ok(updatedSpecialities);
        }

        [HttpDelete("{SPEC_ID}")]
        public async Task<ActionResult> DeleteSpecialitie(int SPEC_ID)
        {
            var Specialities = await _specialitiesService.DeleteSpecialitie(SPEC_ID);
            if (Specialities == null)
            {
                return NotFound("Specialities not found");
            }
            return NoContent();
        }
    }
}

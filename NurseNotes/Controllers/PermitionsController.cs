using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class PermitionsController : ControllerBase
    {
        private readonly IPermitionsService _permitionsService;

        public PermitionsController(IPermitionsService permitionsService)
        {
            _permitionsService = permitionsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Permitions>>> GetAll()
        {
            var permitions = await _permitionsService.GetAll();
            return Ok(permitions);
        }

        [HttpGet("{PER_ID}")]
        public async Task<ActionResult<Permitions>> GetPermition(int PER_ID)
        {
            var permition = await _permitionsService.GetPermition(PER_ID);
            if (permition == null)
            {
                return NotFound("Permition not found");
            }
            return Ok(permition);
        }

        [HttpPost]
        public async Task<ActionResult<Permitions>> CreatePermition([FromBody] Permitions permition)
        {
            if (permition == null)
            {
                return BadRequest("Permition cannot be created");
            }

            var createdPermition = await _permitionsService.CreatePermition(permition);
            return CreatedAtAction(nameof(GetPermition), new { PER_ID = createdPermition.PER_ID }, createdPermition);
        }

        [HttpPut("{PER_ID}")]
        public async Task<ActionResult<Permitions>> UpdatePermition(int PER_ID, [FromBody] Permitions permition)
        {
            if (permition == null || permition.PER_ID != PER_ID)
            {
                return BadRequest("Permition cannot be updated");
            }

            var updatedPermition = await _permitionsService.UpdatePermition(permition);
            if (updatedPermition == null)
            {
                return NotFound("Permition not found");
            }

            return Ok(updatedPermition);
        }

        [HttpDelete("{PER_ID}")]
        public async Task<ActionResult> DeletePermition(int PER_ID)
        {
            var permition = await _permitionsService.DeletePermition(PER_ID);
            if (permition == null)
            {
                return NotFound("Permition not found");
            }
            return NoContent();
        }
    }
}

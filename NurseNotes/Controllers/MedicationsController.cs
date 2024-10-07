using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class MedicationsController : ControllerBase
    {
        private readonly IMedicationsService _mediicationsService;

        public MedicationsController(IMedicationsService MedicationsService)
        {
             _mediicationsService = MedicationsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Medications>>> GetAll()
        {
            var Medications = await _mediicationsService.GetAll();
            return Ok(Medications);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Medications>> GetMedication(int id)
        {
            var Medications = await _mediicationsService.GetMedication(id);
            if (Medications == null)
            {
                return NotFound("Medications not found");
            }
            return Ok(Medications);
        }

        [HttpPost]
        public async Task<ActionResult<Medications>> CreateMedication([FromBody] Medications Medications)
        {
            if (Medications == null)
            {
                return BadRequest("Medications cannot be created");
            }

            var createdMedications = await _mediicationsService.CreateMedication(Medications);
            return CreatedAtAction(nameof(GetMedication), new { id = createdMedications.MED_ID }, createdMedications);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Medications>> UpdateMedication(int id, [FromBody] Medications Medications)
        {
            if (Medications == null || Medications.MED_ID != id)
            {
                return BadRequest("Medications cannot be updated");
            }

            var updatedMedications = await _mediicationsService.UpdateMedication(Medications);
            if (updatedMedications == null)
            {
                return NotFound("Medications not found");
            }

            return Ok(updatedMedications);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteMedication(int id)
        {
            var deletedMedications = await _mediicationsService.DeleteMedication(id);
            if (deletedMedications == null)
            {
                return NotFound("Medications not found");
            }
            return NoContent();
        }
    }
}

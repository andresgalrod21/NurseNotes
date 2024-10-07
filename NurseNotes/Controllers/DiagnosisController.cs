using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class DiagnosisController : ControllerBase
    {
        private readonly IDiagnosisService _diagnosisService;

        public DiagnosisController(IDiagnosisService diagnosisService)
        {
            _diagnosisService = diagnosisService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Diagnosis>>> GetAll()
        {
            var diagnoses = await _diagnosisService.GetAll();
            return Ok(diagnoses);
        }

        [HttpGet("{DIAG_ID}")]
        public async Task<ActionResult<Diagnosis>> GetDiagn(int DIAG_ID)
        {
            var diagnosis = await _diagnosisService.GetDiagn(DIAG_ID);
            if (diagnosis == null)
            {
                return NotFound("Diagnosis not found");
            }
            return Ok(diagnosis);
        }

        [HttpPost]
        public async Task<ActionResult<Diagnosis>> CreateDiagn([FromBody] Diagnosis diagnosis)
        {
            if (diagnosis == null)
            {
                return BadRequest("Diagnosis cannot be created");
            }

            var createdDiagnosis = await _diagnosisService.CreateDiagn(diagnosis);
            return CreatedAtAction(nameof(GetDiagn), new { DIAG_ID = createdDiagnosis.DIAG_ID }, createdDiagnosis);
        }

        [HttpPut("{DIAG_ID}")]
        public async Task<ActionResult<Diagnosis>> UpdateDiagn(int DIAG_ID, [FromBody] Diagnosis diagnosis)
        {
            if (diagnosis == null || diagnosis.DIAG_ID != DIAG_ID)
            {
                return BadRequest("Diagnosis cannot be updated");
            }

            var updatedDiagnosis = await _diagnosisService.UpdateDiagn(diagnosis);
            if (updatedDiagnosis == null)
            {
                return NotFound("Diagnosis not found");
            }

            return Ok(updatedDiagnosis);
        }

        [HttpDelete("{DIAG_ID}")]
        public async Task<ActionResult> DeleteDiagn(int DIAG_ID)
        {
            var deletedDiagnosis = await _diagnosisService.DeleteDiagn(DIAG_ID);
            if (deletedDiagnosis == null)
            {
                return NotFound("Diagnosis not found");
            }
            return NoContent();
        }
    }
}

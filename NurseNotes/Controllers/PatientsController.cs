using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientsService _patientsService;

        public PatientsController(IPatientsService patientsService)
        {
            _patientsService = patientsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Patients>>> GetAll()
        {
            var patients = await _patientsService.GetAll();
            return Ok(patients);
        }

        [HttpGet("{PATIENT_ID}")]
        public async Task<ActionResult<Patients>> GetPatient(int PATIENT_ID)
        {
            var patient = await _patientsService.GetPatient(PATIENT_ID);
            if (patient == null)
            {
                return NotFound("Patient not found");
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<ActionResult<Patients>> CreatePatient([FromBody] Patients patient)
        {
            if (patient == null)
            {
                return BadRequest("Patient cannot be created");
            }

            var createdPatient = await _patientsService.CreatePatient(patient);
            return CreatedAtAction(nameof(GetPatient), new { PATIENT_ID = createdPatient.PATIENT_ID }, createdPatient);
        }

        [HttpPut("{PATIENT_ID}")]
        public async Task<ActionResult<Patients>> UpdatePatient(int PATIENT_ID, [FromBody] Patients patient)
        {
            if (patient == null || patient.PATIENT_ID != PATIENT_ID)
            {
                return BadRequest("Patient cannot be updated");
            }

            var updatedPatient = await _patientsService.UpdatePatient(patient);
            if (updatedPatient == null)
            {
                return NotFound("Patient not found");
            }

            return Ok(updatedPatient);
        }

        [HttpDelete("{PATIENT_ID}")]
        public async Task<ActionResult> DeletePatient(int PATIENT_ID)
        {
            var patient = await _patientsService.DeletePatient(PATIENT_ID);
            if (patient == null)
            {
                return NotFound("Patient not found");
            }
            return NoContent();
        
        }
    }
}
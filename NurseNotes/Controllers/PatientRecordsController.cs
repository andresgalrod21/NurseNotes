using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class PatientRecordsController : ControllerBase
    {
        private readonly IPatientRecordsService _patientRecordsService;

        public PatientRecordsController(IPatientRecordsService patientRecordsService)
        {
            _patientRecordsService = patientRecordsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PatientRecords>>> GetAll()
        {
            var records = await _patientRecordsService.GetAll();
            return Ok(records);
        }

        [HttpGet("{PATR_ID}")]
        public async Task<ActionResult<PatientRecords>> GetPatientRecord(int PATR_ID)
        {
            var record = await _patientRecordsService.GetPatientRecord(PATR_ID);
            if (record == null)
            {
                return NotFound("Patient record not found");
            }
            return Ok(record);
        }

        [HttpPost]
        public async Task<ActionResult<PatientRecords>> CreatePatientRecord([FromBody] PatientRecords record)
        {
            if (record == null)
            {
                return BadRequest("Patient record cannot be created");
            }

            var createdRecord = await _patientRecordsService.CreatePatientRecord(record);
            return CreatedAtAction(nameof(GetPatientRecord), new { PATR_ID = createdRecord.PATR_ID }, createdRecord);
        }

        [HttpPut("{PATR_ID}")]
        public async Task<ActionResult<PatientRecords>> UpdatePatientRecord(int PATR_ID, [FromBody] PatientRecords record)
        {
            if (record == null || record.PATR_ID != PATR_ID)
            {
                return BadRequest("Patient record cannot be updated");
            }

            var updatedRecord = await _patientRecordsService.UpdatePatientRecord(record);
            if (updatedRecord == null)
            {
                return NotFound("Patient record not found");
            }

            return Ok(updatedRecord);
        }

        [HttpDelete("{PATR_ID}")]
        public async Task<ActionResult> DeletePatientRecord(int PATR_ID)
        {
            var deletedRecord = await _patientRecordsService.DeletePatientRecord(PATR_ID);
            if (deletedRecord == null)
            {
                return NotFound("Patient record not found");
            }
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class SuppliesPatientsController : ControllerBase
    {
        private readonly ISuppliesPatientsService _suppliesPatientsService;

        public SuppliesPatientsController(ISuppliesPatientsService suppliesPatientsService)
        {
            _suppliesPatientsService = suppliesPatientsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuppliesPatients>>> GetAll()
        {
            var suppliesPatients = await _suppliesPatientsService.GetAll();
            return Ok(suppliesPatients);
        }

        [HttpGet("{SUP_ID}")]
        public async Task<ActionResult<SuppliesPatients>> GetSuppliesPatient(int SUP_ID)
        {
            var supplyPatient = await _suppliesPatientsService.GetSuppliesPatient(SUP_ID);
            if (supplyPatient == null)
            {
                return NotFound("SupplyPatient not found");
            }
            return Ok(supplyPatient);
        }

        [HttpPost]
        public async Task<ActionResult<SuppliesPatients>> CreateSuppliesPatient([FromBody] SuppliesPatients supplyPatient)
        {
            if (supplyPatient == null)
            {
                return BadRequest("SupplyPatient cannot be created");
            }

            var createdSupplyPatient = await _suppliesPatientsService.CreateSuppliesPatient(supplyPatient);
            return CreatedAtAction(nameof(GetSuppliesPatient), new { SUP_ID = createdSupplyPatient.SUP_ID }, createdSupplyPatient);
        }

        [HttpPut("{SUP_ID}")]
        public async Task<ActionResult<SuppliesPatients>> UpdateSuppliesPatient(int SUP_ID, [FromBody] SuppliesPatients supplyPatient)
        {
            if (supplyPatient == null || supplyPatient.SUP_ID != SUP_ID)
            {
                return BadRequest("SupplyPatient cannot be updated");
            }

            var updatedSupplyPatient = await _suppliesPatientsService.UpdateSuppliesPatient(supplyPatient);
            if (updatedSupplyPatient == null)
            {
                return NotFound("SupplyPatient not found");
            }

            return Ok(updatedSupplyPatient);
        }

        [HttpDelete("{SUP_ID}")]
        public async Task<ActionResult> DeleteSuppliesPatient(int SUP_ID)
        {
            var supplyPatient = await _suppliesPatientsService.DeleteSuppliesPatient(SUP_ID);
            if (supplyPatient == null)
            {
                return NotFound("SupplyPatient not found");
            }
            return NoContent();
        }
    }
}

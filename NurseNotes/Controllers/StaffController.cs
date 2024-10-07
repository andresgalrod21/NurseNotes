using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Staff>>> GetAll()
        {
            var staffMembers = await _staffService.GetAll();
            return Ok(staffMembers);
        }

        [HttpGet("{STAFF_ID}")]
        public async Task<ActionResult<Staff>> GetStaf(int STAFF_ID)
        {
            var staffMember = await _staffService.GetStaf(STAFF_ID);
            if (staffMember == null)
            {
                return NotFound("Staff member not found");
            }
            return Ok(staffMember);
        }

        [HttpPost]
        public async Task<ActionResult<Staff>> CreateStaf([FromBody] Staff staff)
        {
            if (staff == null)
            {
                return BadRequest("Staff member cannot be created");
            }

            var createdStaff = await _staffService.CreateStaf(staff);
            return CreatedAtAction(nameof(GetStaf), new { STAFF_ID = createdStaff.STAFF_ID }, createdStaff);
        }

        [HttpPut("{STAFF_ID}")]
        public async Task<ActionResult<Staff>> UpdateStaf(int STAFF_ID, [FromBody] Staff staff)
        {
            if (staff == null || staff.STAFF_ID != STAFF_ID)
            {
                return BadRequest("Staff member cannot be updated");
            }

            var updatedStaff = await _staffService.UpdateStaf(staff);
            if (updatedStaff == null)
            {
                return NotFound("Staff member not found");
            }

            return Ok(updatedStaff);
        }

        [HttpDelete("{STAFF_ID}")]
        public async Task<ActionResult> DeleteStaf(int STAFF_ID)
        {
            var staffMember = await _staffService.DeleteStaf(STAFF_ID);
            if (staffMember == null)
            {
                return NotFound("Staff member not found");
            }
            return NoContent();
        }
    }
}

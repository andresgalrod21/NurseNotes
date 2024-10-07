using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class PerXGroupsController : ControllerBase
    {
        private readonly IPerXGroupsService _perXGroupsService;

        public PerXGroupsController(IPerXGroupsService perXGroupsService)
        {
            _perXGroupsService = perXGroupsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PerXGroups>>> GetAll()
        {
            var perXGroups = await _perXGroupsService.GetAll();
            return Ok(perXGroups);
        }

        [HttpGet("{PG_ID}")]
        public async Task<ActionResult<PerXGroups>> GetPerXGroup(int PG_ID)
        {
            var perXGroup = await _perXGroupsService.GetPerXGroup(PG_ID);
            if (perXGroup == null)
            {
                return NotFound("PerXGroup not found");
            }
            return Ok(perXGroup);
        }

        [HttpPost]
        public async Task<ActionResult<PerXGroups>> CreatePerXGroup([FromBody] PerXGroups perXGroup)
        {
            if (perXGroup == null)
            {
                return BadRequest("PerXGroup cannot be created");
            }

            var createdPerXGroup = await _perXGroupsService.CreatePerXGroup(perXGroup);
            return CreatedAtAction(nameof(GetPerXGroup), new { PG_ID = createdPerXGroup.PG_ID }, createdPerXGroup);
        }

        [HttpPut("{PG_ID}")]
        public async Task<ActionResult<PerXGroups>> UpdatePerXGroup(int PG_ID, [FromBody] PerXGroups perXGroup)
        {
            if (perXGroup == null || perXGroup.PG_ID != PG_ID)
            {
                return BadRequest("PerXGroup cannot be updated");
            }

            var updatedPerXGroup = await _perXGroupsService.UpdatePerXGroup(perXGroup);
            if (updatedPerXGroup == null)
            {
                return NotFound("PerXGroup not found");
            }

            return Ok(updatedPerXGroup);
        }

        [HttpDelete("{PG_ID}")]
        public async Task<ActionResult> DeletePerXGroup(int PG_ID)
        {
            var perXGroup = await _perXGroupsService.DeletePerXGroup(PG_ID);
            if (perXGroup == null)
            {
                return NotFound("PerXGroup not found");
            }
            return NoContent();
        }
    }
}

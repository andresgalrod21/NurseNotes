using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupsService _groupsService;

        public GroupsController(IGroupsService groupsService)
        {
            _groupsService = groupsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Groups>>> GetAll()
        {
            var groups = await _groupsService.GetAll();
            return Ok(groups);
        }

        [HttpGet("{GRP_ID}")]
        public async Task<ActionResult<Groups>> GetGroup(int GRP_ID)
        {
            var group = await _groupsService.GetGroup(GRP_ID);
            if (group == null)
            {
                return NotFound("Group not found");
            }
            return Ok(group);
        }

        [HttpPost]
        public async Task<ActionResult<Groups>> CreateGroup([FromBody] Groups group)
        {
            if (group == null)
            {
                return BadRequest("Group cannot be created");
            }

            var createdGroup = await _groupsService.CreateGroup(group);
            return CreatedAtAction(nameof(GetGroup), new { GRP_ID = createdGroup.GRP_ID }, createdGroup);
        }

        [HttpPut("{GRP_ID}")]
        public async Task<ActionResult<Groups>> UpdateGroup(int GRP_ID, [FromBody] Groups group)
        {
            if (group == null || group.GRP_ID != GRP_ID)
            {
                return BadRequest("Group cannot be updated");
            }

            var updatedGroup = await _groupsService.UpdateGroup(group);
            if (updatedGroup == null)
            {
                return NotFound("Group not found");
            }

            return Ok(updatedGroup);
        }

        [HttpDelete("{GRP_ID}")]
        public async Task<ActionResult> DeleteGroup(int GRP_ID)
        {
            var deletedGroup = await _groupsService.DeleteGroup(GRP_ID);
            if (deletedGroup == null)
            {
                return NotFound("Group not found");
            }
            return NoContent();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class UsersLogsController : ControllerBase
    {
        private readonly IUsersLogsService _usersLogsService;
        public UsersLogsController(IUsersLogsService usersLogsService)
        {
            _usersLogsService = usersLogsService;
        }
        [HttpGet]
        public async Task<ActionResult<List<UsersLogs>>> GetAll()
        {
            return Ok(await _usersLogsService.GetAll());
        }
        [HttpGet("{ LOG_ID}")]
        public async Task<ActionResult<UsersLogs>> GetUsersLog(int LOG_ID)
        {
            var usersLogs = await _usersLogsService.GetUsersLog(LOG_ID);
            if (usersLogs == null)
            {
                return BadRequest("User Log not found");
            }
            return Ok(usersLogs);
        }

        [HttpPost]
        public async Task<ActionResult<UsersLogs>> CreateUsersLog([FromBody] UsersLogs usersLog)
        {
            if (usersLog == null)
            {
                return BadRequest("User log cannot be created");
            }

            var createdUserLog = await _usersLogsService.CreateUsersLog(usersLog);
            return CreatedAtAction(nameof(GetUsersLog), new { LOG_ID = createdUserLog.LOG_ID }, createdUserLog);
        }

        [HttpPut("{ LOG_ID}")]
        public async Task<ActionResult<UsersLogs>> UpdateUsersLog(int LOG_ID, [FromBody] UsersLogs usersLog)
        {
            if (usersLog == null || usersLog.LOG_ID != LOG_ID)
            {
                return BadRequest("User log cannot be updated");
            }

            var updatedUserLog = await _usersLogsService.UpdateUsersLog(usersLog);
            if (updatedUserLog == null)
            {
                return NotFound("The User log does not exist");
            }

            return Ok(updatedUserLog);
        }

        [HttpDelete("{LOG_ID}")]
        public async Task<ActionResult<Patients>> DeleteUsersLog(int LOG_ID)
        {
            var userLog = await _usersLogsService.DeleteUsersLog(LOG_ID);
            if (userLog == null)
            {
                return BadRequest("The Userlog does not exist");
            }
            return Ok("Userlog Deleted");
        }
    }
}

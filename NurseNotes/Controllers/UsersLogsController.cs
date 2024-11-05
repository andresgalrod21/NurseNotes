using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersLogsController : ControllerBase
    {
        private readonly IUsersLogsService _usersLogsService;

        public UsersLogsController(IUsersLogsService usersLogsService)
        {
            _usersLogsService = usersLogsService;
        }

        // Obtiene todos los logs
        [HttpGet]
        public async Task<ActionResult<List<UsersLogs>>> GetAll()
        {
            var logs = await _usersLogsService.GetAll();
            return Ok(logs);
        }

        // Obtiene un log específico por ID
        [HttpGet("{LOG_ID}")]
        public async Task<ActionResult<UsersLogs>> GetUsersLog(int LOG_ID)
        {
            var usersLog = await _usersLogsService.GetUsersLog(LOG_ID);
            if (usersLog == null)
            {
                return NotFound("User Log not found"); // Ajuste: NotFound en lugar de BadRequest
            }
            return Ok(usersLog);
        }

        // Crea un nuevo log
        [HttpPost]
        public async Task<ActionResult<UsersLogs>> CreateUsersLog([FromBody] UsersLogs usersLog)
        {
            if (usersLog == null)
            {
                return BadRequest("Invalid log data"); // Simplificación del mensaje
            }

            var createdUserLog = await _usersLogsService.CreateUsersLog(usersLog);
            return CreatedAtAction(nameof(GetUsersLog), new { LOG_ID = createdUserLog.LOG_ID }, createdUserLog);
        }

        // Actualiza un log existente
        [HttpPut("{LOG_ID}")]
        public async Task<ActionResult<UsersLogs>> UpdateUsersLog(int LOG_ID, [FromBody] UsersLogs usersLog)
        {
            if (usersLog == null || usersLog.LOG_ID != LOG_ID)
            {
                return BadRequest("Log ID mismatch or invalid data"); // Ajuste de mensaje de error
            }

            var updatedUserLog = await _usersLogsService.UpdateUsersLog(usersLog);
            if (updatedUserLog == null)
            {
                return NotFound("The User log does not exist");
            }

            return Ok(updatedUserLog);
        }

        // Elimina un log por ID
        [HttpDelete("{LOG_ID}")]
        public async Task<ActionResult> DeleteUsersLog(int LOG_ID)
        {
            var userLog = await _usersLogsService.DeleteUsersLog(LOG_ID);
            if (userLog == null)
            {
                return NotFound("The User log does not exist"); // Ajuste: NotFound en lugar de BadRequest
            }
            return Ok("User log deleted successfully");
        }
    }
}

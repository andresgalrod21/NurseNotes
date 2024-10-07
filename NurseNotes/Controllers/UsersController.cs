using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Users>>> GetAll()
        {
            var users = await _usersService.GetAll();
            return Ok(users);
        }

        [HttpGet("{USR_ID}")]
        public async Task<ActionResult<Users>> GetUser(int USR_ID)
        {
            var user = await _usersService.GetUserById(USR_ID);
            if (user == null)
            {
                return NotFound("User not found");
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<Users>> CreateUser([FromBody] Users user)
        {
            if (user == null)
            {
                return BadRequest("User cannot be created");
            }

            var createdUser = await _usersService.CreateUser(user);
            return CreatedAtAction(nameof(GetUser), new { USR_ID = createdUser.USR_ID }, createdUser);
        }

        [HttpPut("{USR_ID}")]
        public async Task<ActionResult<Users>> UpdateUser(int USR_ID, [FromBody] Users user)
        {
            if (user == null || user.USR_ID != USR_ID)
            {
                return BadRequest("User cannot be updated");
            }

            var updatedUser = await _usersService.UpdateUser(user);
            if (updatedUser == null)
            {
                return NotFound("User not found");
            }

            return Ok(updatedUser);
        }

        [HttpDelete("{USR_ID}")]
        public async Task<ActionResult> DeleteUser(int USR_ID)
        {
            var user = await _usersService.DeleteUser(USR_ID);
            if (user == null)
            {
                return NotFound("User not found");
            }
            return NoContent();
        }
    }
}

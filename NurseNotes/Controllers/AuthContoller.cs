using Microsoft.AspNetCore.Mvc;
using NurseNotes.Services;
using System.Threading.Tasks;

namespace NurseNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var user = await _authService.AuthenticateUserAsync(loginRequest.Username, loginRequest.Password);

            if (user == null)
            {
                return Unauthorized(new { success = false, message = "Usuario o contraseña incorrectos" });
            }

            // Retorna un objeto con `success: true` y los detalles del usuario cuando la autenticación es exitosa
            return Ok(new { success = true, token = "your_generated_token_here", user });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

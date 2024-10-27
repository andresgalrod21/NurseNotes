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
                return Unauthorized(new { message = "Usuario o contraseña incorrectos" });
            }

            // Si deseas implementar JWT, aquí generarías y retornarías el token
            // Por ahora solo retornaremos el usuario para simplificar el ejemplo
            return Ok(new { token = "your_generated_token_here", user });
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

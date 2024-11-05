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
            // Autentica al usuario y obtiene el token y la información del usuario
            var authResult = await _authService.AuthenticateUserAsync(loginRequest.Username, loginRequest.Password);

            if (authResult == null)
            {
                // Retorna un error si la autenticación falla
                return Unauthorized(new { success = false, message = "Usuario o contraseña incorrectos" });
            }

            // Retorna un objeto con `success: true`, el token JWT, y los detalles del usuario autenticado
            return Ok(new
            {
                success = true,
                token = authResult.Token,
                user = authResult.User
            });
        }
    }

    // Clase para la solicitud de autenticación
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}

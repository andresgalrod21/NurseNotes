using NurseNotes.Model;
using NurseNotes.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace NurseNotes.Services
{
    public interface IAuthService
    {
        Task<TokenResult?> AuthenticateUserAsync(string username, string password);
    }

    public class AuthService : IAuthService
    {
        private readonly TestDbNurseNotes _context;

        public AuthService(TestDbNurseNotes context)
        {
            _context = context;
        }

        public async Task<TokenResult?> AuthenticateUserAsync(string username, string password)
        {
            // Busca al usuario por nombre de usuario
            var user = await _context.Users.FirstOrDefaultAsync(u => u.USR == username);

            if (user == null) return null; // Usuario no encontrado

            // Decodifica la contraseña almacenada en Base64
            string decodedPassword = DecodePassword(user.USRPSW);

            // Compara la contraseña ingresada con la decodificada
            if (decodedPassword != password) return null; // Contraseña incorrecta

            // Generar token JWT
            string token = "your_generated_token_here"; // Suponiendo que aquí generas el token

            // Crear el registro de log de usuario con el objeto `Users` requerido
            var userLog = new UsersLogs
            {
                USR_ID = user.USR_ID,
                FCHMOD = DateTime.Now,
                USRMOD = "Inicio de sesión",
                Users = user // Asigna el objeto `Users` requerido
            };

            // Agregar el log a la base de datos
            await _context.UsersLogs.AddAsync(userLog);
            await _context.SaveChangesAsync();

            return new TokenResult
            {
                Token = token,
                User = user
            };
        }

        private string DecodePassword(string encodedPassword)
        {
            byte[] passwordBytes = Convert.FromBase64String(encodedPassword);
            return Encoding.UTF8.GetString(passwordBytes);
        }
    }

    // Clase para representar el resultado de la autenticación, incluyendo el token y el usuario
    public class TokenResult
    {
        public string Token { get; set; }
        public Users User { get; set; }
    }
}

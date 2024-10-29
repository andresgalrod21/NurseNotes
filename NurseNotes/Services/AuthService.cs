using NurseNotes.Model;
using NurseNotes.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace NurseNotes.Services
{
    public interface IAuthService
    {
        Task<Users?> AuthenticateUserAsync(string username, string password);
    }

    public class AuthService : IAuthService
    {
        private readonly TestDbNurseNotes _context;

        public AuthService(TestDbNurseNotes context)
        {
            _context = context;
        }

        public async Task<Users?> AuthenticateUserAsync(string username, string password)
        {
            // Busca al usuario por nombre de usuario
            var user = await _context.Users
                                      .FirstOrDefaultAsync(u => u.USR == username);

            if (user == null)
            {
                return null; // Usuario no encontrado
            }

            // Decodifica la contraseña almacenada en Base64
            string decodedPassword = DecodePassword(user.USRPSW);

            // Compara la contraseña ingresada con la decodificada
            if (decodedPassword != password)
            {
                return null; // Contraseña incorrecta
            }

            return user; // Usuario autenticado correctamente
        }

        private string DecodePassword(string encodedPassword)
        {
            byte[] passwordBytes = Convert.FromBase64String(encodedPassword);
            return Encoding.UTF8.GetString(passwordBytes);
        }
    }
}


using NurseNotes.Model;
using NurseNotes.Context;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            // Busca al usuario con las credenciales proporcionadas
            return await _context.Users
                                 .FirstOrDefaultAsync(u => u.USR == username && u.USRPSW == password);
        }
    }
}

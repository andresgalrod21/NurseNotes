using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NurseNotes.Model;
using NurseNotes.Repositorio;

namespace NurseNotes.Services
{
    public interface IUsersService
    {
        Task<List<Users>> GetAll();
        Task<Users> GetUserById(int USR_ID);
        Task<Users> CreateUser(Users user);
        Task<Users> UpdateUser(Users user);
        Task<Users> DeleteUser(int USR_ID);

    }

    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;

        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<List<Users>> GetAll()
        {
            return await _usersRepository.GetAll();
        }

        public async Task<Users> GetUserById(int USR_ID)
        {
            return await _usersRepository.GetUserById(USR_ID);
        }

        // Modificación en el método CreateUser para encriptar la contraseña en Base64
        public async Task<Users> CreateUser(Users user)
        {
            // Convertir la contraseña en una cadena en Base64 antes de guardarla
            byte[] passwordBytes = Encoding.UTF8.GetBytes(user.USRPSW);
            user.USRPSW = Convert.ToBase64String(passwordBytes);

            return await _usersRepository.CreateUser(
                user.USR_ID, user.NAME, user.LASTNAME,
                user.TIPDOC, user.NUMDOC, user.USRPSW,
                user.USR, user.MAIL, user.FCHCREATION, user.GRP_ID
            );
        }

        public async Task<Users> UpdateUser(Users user)
        {
            return await _usersRepository.UpdateUser(user);
        }

        public async Task<Users> DeleteUser(int USR_ID)
        {
            return await _usersRepository.DeleteUser(USR_ID);
        }


        // Método para decodificar la contraseña Base64 (si necesitas verla en texto plano)
        //public string DecodePassword(string encodedPassword)
        //{
        //    byte[] passwordBytes = Convert.FromBase64String(encodedPassword);
        //    return Encoding.UTF8.GetString(passwordBytes);
        //}
    }
}

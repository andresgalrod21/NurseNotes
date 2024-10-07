using System.Collections.Generic;
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

        public async Task<Users> CreateUser(Users user)
        {
            return await _usersRepository.CreateUser(
                            user.USR_ID, user.NAME, user.LASTNAME,
                            user.TIPDOC, user.NUMDOC, user.USRPSW,
                            user.USR, user.FCHCREATION, user.GRP_ID);
        }

        public async Task<Users> UpdateUser(Users user)
        {
            return await _usersRepository.UpdateUser(user);
        }

        public async Task<Users> DeleteUser(int USR_ID)
        {
            return await _usersRepository.DeleteUser(USR_ID);
        }
    }
}

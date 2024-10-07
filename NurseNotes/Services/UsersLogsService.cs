using System.Collections.Generic;
using System.Threading.Tasks;
using NurseNotes.Model;

namespace NurseNotes.Services
{
    public interface IUsersLogsRepository
    {
        Task<List<UsersLogs>> GetAll();
        Task<UsersLogs> GetUsersLog(int LOG_ID);
        Task<UsersLogs> CreateUsersLog(UsersLogs usersLog);
        Task<UsersLogs> UpdateUsersLog(UsersLogs usersLog);
        Task<UsersLogs> DeleteUsersLog(int LOG_ID);
    }
    public class UsersLogsService : IUsersLogsRepository
    {
        readonly IUsersLogsRepository _usersLogsRepository;
        public UsersLogsService(IUsersLogsRepository usersLogsRepository)
        {
            _usersLogsRepository = usersLogsRepository;
        }

        public async Task<List<UsersLogs>> GetAll()
        {
            return await _usersLogsRepository.GetAll();
        }

        public async Task<UsersLogs> GetUsersLog(int LOG_ID)
        {
            return await _usersLogsRepository.GetUsersLog(LOG_ID);
        }

        public async Task<UsersLogs> CreateUsersLog(UsersLogs usersLog)
        {
            return await _usersLogsRepository.CreateUsersLog(usersLog);
        }

        public async Task<UsersLogs> UpdateUsersLog(UsersLogs usersLog)
        {
            return await _usersLogsRepository.UpdateUsersLog(usersLog);
        }

        public async Task<UsersLogs> DeleteUsersLog(int LOG_ID)
        {
            return await _usersLogsRepository.DeleteUsersLog(LOG_ID);
        }
    }
}

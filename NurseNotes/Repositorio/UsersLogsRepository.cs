using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using NurseNotes.Context;
using NurseNotes.Model;
using System.Security.Cryptography.Xml;

namespace NurseNotes.Repositorio
{

    public interface IUsersLogsRepository
    {
        Task<List<UsersLogs>> GetAll();
        Task<UsersLogs> GetUsersLog(int LOG_ID);
        Task<UsersLogs> CreateUsersLog(int LOG_ID, int USR_ID, DateTime FCHMOD, string USRMOD);
        Task<UsersLogs> GetUsersLogByUsrMod(int USRMOD);
        Task<UsersLogs> UpdateUsersLog(UsersLogs usersLogs);
        Task<UsersLogs> DeleteUsersLog(int LOG_ID);
    }
    public class UsersLogsRepository : IUsersLogsRepository
    {
        private readonly TestDbNurseNotes _db;
        public UsersLogsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<UsersLogs> CreateUsersLog(int LOG_ID, int USR_ID, DateTime FCHMOD, string USRMOD)
        {
            throw new NotImplementedException();
        }

        public Task<UsersLogs> DeleteUsersLog(int LOG_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsersLogs>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UsersLogs> GetUsersLog(int LOG_ID)
        {
            throw new NotImplementedException();
        }

        public Task<UsersLogs> GetUsersLogByUsrMod(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<UsersLogs> UpdateUsersLog(UsersLogs usersLogs)
        {
            throw new NotImplementedException();
        }
    }

}

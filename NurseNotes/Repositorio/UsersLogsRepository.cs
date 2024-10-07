using Microsoft.EntityFrameworkCore;
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

        public async Task<List<UsersLogs>> GetAll()
        {
            return await _db.UsersLogs.ToListAsync();
        }

        public async Task<UsersLogs> GetUsersLog(int LOG_ID)
        {
            return await _db.UsersLogs.FirstOrDefaultAsync(log => log.LOG_ID == LOG_ID);
        }

        public async Task<UsersLogs> CreateUsersLog(int LOG_ID, int USR_ID, DateTime FCHMOD, string USRMOD)
        {
            Users user = await _db.Users.FindAsync(USR_ID);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            UsersLogs newLog = new UsersLogs
            {
                LOG_ID = LOG_ID,
                USR_ID = USR_ID,
                FCHMOD = FCHMOD,
                USRMOD = USRMOD,
                Users = user
            };

            await _db.UsersLogs.AddAsync(newLog);
            await _db.SaveChangesAsync();

            return newLog;
        }

        public async Task<UsersLogs> UpdateUsersLog(UsersLogs usersLogs)
        {
            _db.UsersLogs.Update(usersLogs);
            await _db.SaveChangesAsync();
            return usersLogs;
        }

        public async Task<UsersLogs> DeleteUsersLog(int LOG_ID)
        {
            UsersLogs usersLogs = await GetUsersLog(LOG_ID);
            _db.UsersLogs.Remove(usersLogs);
            await _db.SaveChangesAsync();

            return usersLogs;
        }

    }

}

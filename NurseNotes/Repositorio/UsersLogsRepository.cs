using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Query;
using NurseNotes.Model;
using System.Security.Cryptography.Xml;

namespace NurseNotes.Repositorio
{

    public interface IUsersLogsRepository
    {
        Task<IEnumerable<UsersLogs>> getallsubjectsAsync();
        Task<UsersLogs> getsubjectbyIdAsync(int LOG_ID);
        Task CreateUsersLogsAsync(UsersLogs UsersLogs);
        Task UpdateUsersLogssync(UsersLogs UsersLogs);
        Task SoftDeleteUsersLogsAsync(UsersLogs UsersLogs);
    }
    public class UsersLogsRepository
    {
        public UsersLogsRepository()
        {
        }

        public Task CreateUsersLogsAsync(UsersLogs UsersLogs)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UsersLogs> getsubjectbyIdAsync(int LOG_ID)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUsersAsync(UsersLogs UsersLogs)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUsersLogsAsync(UsersLogs UsersLogs)
        {
            throw new NotImplementedException();
        }
    }

}

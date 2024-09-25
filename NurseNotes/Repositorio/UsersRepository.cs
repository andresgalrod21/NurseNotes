

using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> getallsubjectsAsync();
        Task<Users> getsubjectbyIdAsync(int USR_ID);
        Task CreateUsersAsync(Users Users);
        Task UpdateUsersAsync(Users Users);
        Task SoftDeleteUsersAsync(Users Users);
    }

    public class UserssRepository
    {
        public UserssRepository()
        {
            
        }
        public Task CreateUsersAsync(Users Users)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Users>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Users> getsubjectbyIdAsync(int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUsersAsync(Users Users)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUsersAsync(Users Users)
        {
            throw new NotImplementedException();
        }
    }
}

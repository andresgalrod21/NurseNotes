using static NurseNotes.Model.IUserRepository;

namespace NurseNotes.Repositorio
{

    public interface IUserRepository
    {
        Task<IEnumerable<User>> getallsubjectsAsync();
        Task<User> getsubjectbyIdAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(User user);
    }

    public class UserRepository : IUserRepository
    {

        public UserRepository() { }

        public Task CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> getsubjectbyIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}

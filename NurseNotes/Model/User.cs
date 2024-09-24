namespace NurseNotes.Model
{

    public interface IUserRepository
    {
        Task<IEnumerable<User>> getallsubjectsAsync();
        Task<User> getsubjectbyIdAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task SoftDeleteUserAsync(User user);

        public class User
        {
            public int Id { get; set; }
            public required string Name { get; set; }
            public required string Email { get; set; }
            public required string Password { get; set; }

            public required string Username { get; set; }
            //definir llaves primarias y autoincremental

            public required UserTIpe UserTIpe { get; set; }
        }
    }
}

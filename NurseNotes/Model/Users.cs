namespace NurseNotes.Model
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> getallsubjectsAsync();
        Task<Users> getsubjectbyIdAsync(int id);
        Task CreateUserAsync(Users users);
        Task UpdateUserAsync(Users users);
        Task SoftDeleteUserAsync(Users users);
        public class Users
        {


            public int USR_ID { get; set; }
            public required string NAME { get; set; }
            public required string LASTNAME { get; set; }
            public required string TIPDOC { get; set; }
            public required int NUMDOC { get; set; }
            public required string USRPSW { get; set; }
            public required string USR { get; set; }
            public required DateTime FCHCREATION { get; set; }
            public int GRP_ID { get; set; }
        }
    }
}

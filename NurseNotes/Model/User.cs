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
            //public int USR_ID { get; set; }
            //public required string NAME { get; set; }
            //public required string LASTNAME { get; set; }
            //public required string TIPDOC { get; set; }
            //public required int NUMDOC { get; set; }
            //public required string USRPSW { get; set; }
            //public required string USR {  get; set; }
            //public required DateTime FCHCREATION { get; set; }
            //public int GRP_ID {  get; set; }

            //definir llaves primarias y autoincremental

            //public required UserTIpe UserTIpe { get; set; }

            /*El enfoque para la creación de la clase debe tener
       el uso de decoradores para el autogenerar o la funcion modelcreating

       Deben quedar definidas las llaves primarias como el autoincremental
        */

        }
    }
}

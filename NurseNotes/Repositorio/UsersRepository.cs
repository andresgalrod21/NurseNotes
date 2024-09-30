using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;
using System.Numerics;

namespace NurseNotes.Repositorio
{
    public interface IUsersRepository
    {
        Task<List<Users>> GetAll();
        Task<Users> GetPerson(int USR_ID);
        Task<Users> CreatePerson(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION);
        Task<Users> GetPersonByDocument(int NUMDOC);
        Task<Users> CreatePerson(Users users, string USRPSW);
        Task<Users> UpdatePerson(Users users);
        Task<Users> DeletePerson(int USR_ID);

    }
        public class UsersRepository : IUsersRepository
        {
            private readonly TestDbNurseNotes _db;
            public UsersRepository(TestDbNurseNotes db)
            {
                _db = db;
            }

            public Task<Users> CreatePerson(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION)
            {
                throw new NotImplementedException();
            }

            public Task<Users> CreatePerson(Users users, string USRPSW)
            {
                throw new NotImplementedException();
            }

            public Task<Users> DeletePerson(int USR_ID)
            {
                throw new NotImplementedException();
            }

            public Task<List<Users>> GetAll()
            {
                throw new NotImplementedException();
            }

            public Task<Users> GetPerson(int USR_ID)
            {
                throw new NotImplementedException();
            }

            public Task<Users> GetPersonByDocument(int NUMDOC)
            {
                throw new NotImplementedException();
            }

            public Task<Users> UpdatePerson(Users users)
            {
                throw new NotImplementedException();
            }


            //----------------------------------------------

        }
    
}

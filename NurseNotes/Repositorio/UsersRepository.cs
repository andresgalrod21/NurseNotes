using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;
using System.Numerics;

namespace NurseNotes.Repositorio
{
    public interface IUsersRepository
    {
        Task<List<Users>> GetAll();
        Task<Users> GetUser(int USR_ID);
        Task<Users> CreateUser(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION);
        Task<Users> GetUserByDocument(int NUMDOC);
        Task<Users> UpdateUser(Users users);
        Task<Users> DeleteUser(int USR_ID);

    }
        public class UsersRepository : IUsersRepository
        {
            private readonly TestDbNurseNotes _db;
            public UsersRepository(TestDbNurseNotes db)
            {
                _db = db;
            }

        public Task<Users> CreateUser(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION)
        {
            throw new NotImplementedException();
        }

        public Task<Users> DeleteUser(int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Users>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUser(int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Users> GetUserByDocument(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<Users> UpdateUser(Users users)
        {
            throw new NotImplementedException();
        }



        //----------------------------------------------

    }
    
}

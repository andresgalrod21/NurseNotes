using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;
using System.Numerics;

namespace NurseNotes.Repositorio
{
    public interface IUsersRepository
    {
        Task<List<Users>> GetAll();
        Task<Users> GetUserById(int USR_ID);
        Task<Users> CreateUser(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION, int GRP_ID);
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

        public async Task<List<Users>> GetAll()
        {
            return await _db.Users.ToListAsync();
        }

        public async Task<Users> GetUserById(int USR_ID)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.USR_ID == USR_ID);
        }

        public async Task<Users> CreateUser(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION, int GRP_ID)
        {
            Groups group = await _db.Groups.FindAsync(GRP_ID);
            if (group == null)
            {
                throw new Exception("Group not found");
            }

            Users newUser = new Users
            {
                USR_ID = USR_ID,
                NAME = NAME,
                LASTNAME = LASTNAME,
                TIPDOC = TIPDOC,
                NUMDOC = NUMDOC,
                USRPSW = USRPSW,
                USR = USR,
                FCHCREATION = FCHCREATION,
                GRP_ID = GRP_ID,
                Group = group
            };

            await _db.Users.AddAsync(newUser);
            await _db.SaveChangesAsync();

            return newUser;
        }

        public async Task<Users> UpdateUser(Users users)
        {
            _db.Users.Update(users);
            await _db.SaveChangesAsync();
            return users;
        }

        public async Task<Users> DeleteUser(int USR_ID)
        {
            Users users = await GetUserById(USR_ID);

            _db.Users.Update(users);
            await _db.SaveChangesAsync();
            return users;
        }


        //----------------------------------------------

    }
    
}

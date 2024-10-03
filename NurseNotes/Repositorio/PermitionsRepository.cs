using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPermitionsRepository
    {
        Task<List<Permitions>> GetAll();
        Task<Permitions> GetPermition(int PER_ID);
        Task<Permitions> CreatePermition(int PER_ID, string PERDSC);
        Task<Permitions> GetPermitionByPerDsc(int PERDSC);
        Task<Permitions> UpdatePermition(Permitions permitions);
        Task<Permitions> DeletePermition(int PER_ID);

    }
    public class PermitionsRepository : IPermitionsRepository
    {
        private readonly TestDbNurseNotes _db;
        public PermitionsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Permitions> CreatePermition(int PER_ID, string PERDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Permitions> DeletePermition(int PER_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Permitions>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Permitions> GetPermition(int PER_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Permitions> GetPermitionByPerDsc(int PERDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Permitions> UpdatePermition(Permitions permitions)
        {
            throw new NotImplementedException();
        }
    }
}

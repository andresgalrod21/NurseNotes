using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IHeadqueartersRepository
    {
        Task<List<Headquearters>> GetAll();
        Task<Headquearters> GetHeadquearter(int HEADQ_ID);
        Task<Headquearters> CreateHeadquearter(int HEADQ_ID, string HEADQDSC);
        Task<Headquearters> GetHeadquearterByHeadq(int HEADQDSC);
        Task<Headquearters> UpdateHeadquearter(Headquearters headquearters);
        Task<Headquearters> DeleteHeadquearter(int HEADQ_ID);

    }
    public class Headquearters : IHeadqueartersRepository
    {
        private readonly TestDbNurseNotes _db;
        public Headquearters(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Headquearters> CreateHeadquearter(int HEADQ_ID, string HEADQDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Headquearters> DeleteHeadquearter(int HEADQ_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Headquearters>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Headquearters> GetHeadquearter(int HEADQ_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Headquearters> GetHeadquearterByHeadq(int HEADQDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Headquearters> UpdateHeadquearter(Headquearters headquearters)
        {
            throw new NotImplementedException();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IHeadqueartersRepository
    {
        Task<List<Headquearters>> GetAll();
        Task<Headquearters> GetHeadquearter(int HEADQ_ID);
        Task<Headquearters> CreateHeadquearter(int HEADQ_ID, string HEADQDSC);
        Task<Headquearters> UpdateHeadquearter(Headquearters headquearters);
        Task<Headquearters> DeleteHeadquearter(int HEADQ_ID);

    }
    public class HeadqueartersRepository : IHeadqueartersRepository
    {
        private readonly TestDbNurseNotes _db;
        public HeadqueartersRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Headquearters>> GetAll()
        {
            return await _db.Headquearters.ToListAsync();
        }

        public async Task<Headquearters> GetHeadquearter(int HEADQ_ID)
        {
            return await _db.Headquearters.FindAsync(HEADQ_ID);
        }

        public async Task<Headquearters> CreateHeadquearter(int HEADQ_ID, string HEADQDSC)
        {
            Headquearters newHeadquearters = new Headquearters
            {
                HEADQ_ID = HEADQ_ID,
                HEADQDSC = HEADQDSC
            };

            await _db.Headquearters.AddAsync(newHeadquearters);
            await _db.SaveChangesAsync();

            return newHeadquearters;
        }

        public async Task<Headquearters> UpdateHeadquearter(Headquearters headquearters)
        {
            _db.Headquearters.Update(headquearters);
            await _db.SaveChangesAsync();
            return headquearters;
        }

        public async Task<Headquearters> DeleteHeadquearter(int HEADQ_ID)
        {
            Headquearters headquearters = await GetHeadquearter(HEADQ_ID);
            _db.Headquearters.Remove(headquearters);
            await _db.SaveChangesAsync();

            return headquearters;
        }
    }
}

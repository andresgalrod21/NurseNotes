using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPermitionsRepository
    {
        Task<List<Permitions>> GetAll();
        Task<Permitions> GetPermition(int PER_ID);
        Task<Permitions> CreatePermition(int PER_ID, string PERDSC);
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

        public async Task<List<Permitions>> GetAll()
        {
            return await _db.Permitions.ToListAsync();
        }

        public async Task<Permitions> GetPermition(int PER_ID)
        {
            return await _db.Permitions.FirstOrDefaultAsync(p => p.PER_ID == PER_ID);
        }

        public async Task<Permitions> CreatePermition(int PER_ID, string PERDSC)
        {
            Permitions newPermition = new Permitions
            {
                PER_ID = PER_ID,
                PERDSC = PERDSC
            };

            await _db.Permitions.AddAsync(newPermition);
            await _db.SaveChangesAsync();

            return newPermition;
        }

        public async Task<Permitions> UpdatePermition(Permitions permitions)
        {
            _db.Permitions.Update(permitions);
            await _db.SaveChangesAsync();
            return permitions;
        }

        public async Task<Permitions> DeletePermition(int PER_ID)
        {
            Permitions permitions = await GetPermition(PER_ID);
            _db.Permitions.Remove(permitions);
            await _db.SaveChangesAsync();

            return permitions;
        }
    }
}

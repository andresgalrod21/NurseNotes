using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ISpecialitiesRepository
    {
        Task<List<Specialities>> GetAll();
        Task<Specialities> GetSpecialitie(int SPEC_ID);
        Task<Specialities> CreateSpecialitie(int SPEC_ID, string SPECDSC);
        Task<Specialities> UpdateSpecialitie(Specialities specialities);
        Task<Specialities> DeleteSpecialitie(int SPEC_ID);

    }
    public class SpecialitiesRepository : ISpecialitiesRepository
    {
        private readonly TestDbNurseNotes _db;
        public SpecialitiesRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Specialities>> GetAll()
        {
            return await _db.Specialities.ToListAsync();
        }

        public async Task<Specialities> GetSpecialitie(int SPEC_ID)
        {
            return await _db.Specialities.FirstOrDefaultAsync(s => s.SPEC_ID == SPEC_ID);
        }

        public async Task<Specialities> CreateSpecialitie(int SPEC_ID, string SPECDSC)
        {
            Specialities newSpeciality = new Specialities
            {
                SPEC_ID = SPEC_ID,
                SPECDSC = SPECDSC
            };

            await _db.Specialities.AddAsync(newSpeciality);
            await _db.SaveChangesAsync();

            return newSpeciality;
        }

        public async Task<Specialities> UpdateSpecialitie(Specialities specialities)
        {
            _db.Specialities.Update(specialities);
            await _db.SaveChangesAsync();
            return specialities;
        }

        public async Task<Specialities> DeleteSpecialitie(int SPEC_ID)
        {
            Specialities specialities = await GetSpecialitie(SPEC_ID);
            _db.Specialities.Remove(specialities);
            await _db.SaveChangesAsync();

            return specialities;
        }
    }
}

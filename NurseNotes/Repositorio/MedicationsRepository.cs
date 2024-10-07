using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IMedicationsRepository
    {
        Task<List<Medications>> GetAll();
        Task<Medications> GetMedication(int MED_ID);
        Task<Medications> CreateMedication(int MED_ID, string MEDDSC, int STOCK);
        Task<Medications> UpdateMedication(Medications Medications);
        Task<Medications> DeleteMedication(int MED_ID);

    }
    public class MedicationsRepository : IMedicationsRepository
    {
        private readonly TestDbNurseNotes _db;
        public MedicationsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Medications>> GetAll()
        {
            return await _db.Medications.ToListAsync();
        }

        public async Task<Medications> GetMedication(int MED_ID)
        {
            return await _db.Medications.FirstOrDefaultAsync(m => m.MED_ID == MED_ID);
        }

        public async Task<Medications> CreateMedication(int MED_ID, string MEDDSC, int STOCK)
        {
            Medications newMedication = new Medications
            {
                MED_ID = MED_ID,
                MEDDSC = MEDDSC,
                STOCK = STOCK
            };

            await _db.Medications.AddAsync(newMedication);
            await _db.SaveChangesAsync();

            return newMedication;
        }

        public async Task<Medications> UpdateMedication(Medications medications)
        {
            _db.Medications.Update(medications);
            await _db.SaveChangesAsync();
            return medications;
        }

        public async Task<Medications> DeleteMedication(int MED_ID)
        {
            Medications medications = await GetMedication(MED_ID);
            _db.Medications.Remove(medications);
            await _db.SaveChangesAsync();

            return medications;
        }
    }
}

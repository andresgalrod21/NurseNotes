using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ISuppliesPatientsRepository
    {
        Task<List<SuppliesPatients>> GetAll();
        Task<SuppliesPatients> GetSuppliesPatient(int SUP_ID);
        Task<SuppliesPatients> CreateSuppliesPatient(int SUP_ID, int CANTSUP, int INCOME_ID, int MED_ID);
        Task<SuppliesPatients> UpdateSuppliesPatient(SuppliesPatients suppliesPatients);
        Task<SuppliesPatients> DeleteSuppliesPatient(int SUP_ID);

    }
    public class SuppliesPatientsRepository : ISuppliesPatientsRepository
    {
        private readonly TestDbNurseNotes _db;
        public SuppliesPatientsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<SuppliesPatients>> GetAll()
        {
            return await _db.SuppliesPatients.ToListAsync();
        }

        public async Task<SuppliesPatients> GetSuppliesPatient(int SUP_ID)
        {
            return await _db.SuppliesPatients.FirstOrDefaultAsync(sp => sp.SUP_ID == SUP_ID);
        }

        public async Task<SuppliesPatients> CreateSuppliesPatient(int SUP_ID, int CANTSUP, int INCOME_ID, int MED_ID)
        {
            Incomes Incomes = await _db.Incomes.FindAsync(INCOME_ID);
            if (Incomes == null)
            {
                throw new Exception("Income not found");
            }
            Medications Medications = await _db.Medications.FindAsync(MED_ID);
            if (Medications == null)
            {
                throw new Exception("Medication not found");
            }

            SuppliesPatients newSuppliesPatient = new SuppliesPatients
            {
                SUP_ID = SUP_ID,
                CANTSUP = CANTSUP,
                INCOME_ID = INCOME_ID,
                MED_ID = MED_ID,
                Incomes = Incomes,
                Medications = Medications
            };

            await _db.SuppliesPatients.AddAsync(newSuppliesPatient);
            await _db.SaveChangesAsync();

            return newSuppliesPatient;
        }

        public async Task<SuppliesPatients> UpdateSuppliesPatient(SuppliesPatients suppliesPatients)
        {
            _db.SuppliesPatients.Update(suppliesPatients);
            await _db.SaveChangesAsync();
            return suppliesPatients;
        }

        public async Task<SuppliesPatients> DeleteSuppliesPatient(int SUP_ID)
        {
            SuppliesPatients suppliesPatients = await GetSuppliesPatient(SUP_ID);
            _db.SuppliesPatients.Remove(suppliesPatients);
            await _db.SaveChangesAsync();

            return suppliesPatients;
        }
    }
}

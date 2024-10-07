using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IIncomesRepository
    {
        Task<List<Incomes>> GetAll();
        Task<Incomes> GetIncome(int INCOME_ID);
        Task<Incomes> CreateIncome(int INCOME_ID ,int TIPDOC_ID , int PATIENT_ID, DateTime FCHINCOME, int USR_ID);
        Task<Incomes> UpdateIncome(Incomes incomes);
        Task<Incomes> DeleteIncome(int INCOME_ID);

    }
    public class IncomesRepository : IIncomesRepository
    {
        private readonly TestDbNurseNotes _db;
        public IncomesRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Incomes>> GetAll()
        {
            return await _db.Incomes.ToListAsync();
        }

        public async Task<Incomes> GetIncome(int INCOME_ID)
        {
            return await _db.Incomes.FirstOrDefaultAsync(i => i.INCOME_ID == INCOME_ID);
        }

        public async Task<Incomes> CreateIncome(int INCOME_ID, int TIPDOC_ID, int PATIENT_ID, DateTime FCHINCOME, int USR_ID)
        {
            TipDocs tipDocs = await _db.TipDocs.FindAsync(TIPDOC_ID);
            if (tipDocs == null)
            {
                throw new Exception("Tipdoc not found");
            }

            Patients patients = await _db.Patients.FindAsync(PATIENT_ID);
            if (patients == null)
            {
                throw new Exception("Patient not found");
            }

            Users users = await _db.Users.FindAsync(USR_ID);
            if (users == null)
            {
                throw new Exception("User not found");
            }

            Incomes newIncome = new Incomes
            {
                INCOME_ID = INCOME_ID,
                TIPDOC_ID = TIPDOC_ID,
                PATIENT_ID = PATIENT_ID,
                FCHINCOME = FCHINCOME,
                USR_ID = USR_ID,
                TipDocs = tipDocs,
                Patients = patients,
                Users = users
            };

            await _db.Incomes.AddAsync(newIncome);
            await _db.SaveChangesAsync();

            return newIncome;
        }

        public async Task<Incomes> UpdateIncome(Incomes incomes)
        {
            _db.Incomes.Update(incomes);
            await _db.SaveChangesAsync();
            return incomes;
        }

        public async Task<Incomes> DeleteIncome(int INCOME_ID)
        {
            Incomes incomes = await GetIncome(INCOME_ID);
            _db.Incomes.Remove(incomes);
            await _db.SaveChangesAsync();

            return incomes;
        }
    }
}

using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IIncomesRepository
    {
        Task<List<Incomes>> GetAll();
        Task<Incomes> GetIncome(int INCOME_ID);
        Task<Incomes> CreateIncome(int INCOME_ID /*,int TIPDOC_ID */, int PATIENT_ID, DateTime FCHINCOME, int USR_ID);
        Task<Incomes> GetIncomeByFch(int FCHINCOME);
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

        public Task<Incomes> CreateIncome(int INCOME_ID, int PATIENT_ID, DateTime FCHINCOME, int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Incomes> DeleteIncome(int INCOME_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Incomes>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Incomes> GetIncome(int INCOME_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Incomes> GetIncomeByFch(int FCHINCOME)
        {
            throw new NotImplementedException();
        }

        public Task<Incomes> UpdateIncome(Incomes incomes)
        {
            throw new NotImplementedException();
        }
    }
}

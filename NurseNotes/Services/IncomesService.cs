using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IIncomesService
    {
        Task<List<Incomes>> GetAll();
        Task<Incomes> GetIncome(int INCOME_ID);
        Task<Incomes> CreateIncome(Incomes income);
        Task<Incomes> UpdateIncome(Incomes income);
        Task<Incomes> DeleteIncome(int INCOME_ID);

    }
    public class IncomesService : IIncomesService
    {
        private readonly IIncomesRepository _incomesRepository;

        public IncomesService(IIncomesRepository incomesRepository)
        {
            _incomesRepository = incomesRepository;
        }

        public async Task<List<Incomes>> GetAll()
        {
            return await _incomesRepository.GetAll();
        }

        public async Task<Incomes> GetIncome(int INCOME_ID)
        {
            return await _incomesRepository.GetIncome(INCOME_ID);
        }

        public async Task<Incomes> CreateIncome(Incomes income)
        {
            return await _incomesRepository.CreateIncome(
                income.INCOME_ID, income.TIPDOC_ID, income.PATIENT_ID,
                income.FCHINCOME, income.USR_ID);
        }

        public async Task<Incomes> UpdateIncome(Incomes income)
        {
            return await _incomesRepository.UpdateIncome(income);
        }

        public async Task<Incomes> DeleteIncome(int INCOME_ID)
        {
            return await _incomesRepository.DeleteIncome(INCOME_ID);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using NurseNotes.Model;
using NurseNotes.Repositorio;

namespace NurseNotes.Services
{
    public interface ISuppliesPatientsService
    {
        Task<List<SuppliesPatients>> GetAll();
        Task<SuppliesPatients> GetSuppliesPatient(int SUP_ID);
        Task<SuppliesPatients> CreateSuppliesPatient(SuppliesPatients suppliesPatient);
        Task<SuppliesPatients> UpdateSuppliesPatient(SuppliesPatients suppliesPatient);
        Task<SuppliesPatients> DeleteSuppliesPatient(int SUP_ID);

    }
    public class SuppliesPatientsService : ISuppliesPatientsService
    {
        readonly ISuppliesPatientsRepository _suppliesPatientsRepository;

        public SuppliesPatientsService(ISuppliesPatientsRepository suppliesPatientsRepository)
        {
            _suppliesPatientsRepository = suppliesPatientsRepository;
        }

        public async Task<List<SuppliesPatients>> GetAll()
        {
            return await _suppliesPatientsRepository.GetAll();
        }

        public async Task<SuppliesPatients> GetSuppliesPatient(int SUP_ID)
        {
            return await _suppliesPatientsRepository.GetSuppliesPatient(SUP_ID);
        }

        public async Task<SuppliesPatients> CreateSuppliesPatient(SuppliesPatients suppliesPatient)
        {
            return await _suppliesPatientsRepository.CreateSuppliesPatient(
                suppliesPatient.SUP_ID, suppliesPatient.CANTSUP, suppliesPatient.INCOME_ID,
                suppliesPatient.MED_ID);
        }

        public async Task<SuppliesPatients> UpdateSuppliesPatient(SuppliesPatients suppliesPatient)
        {
            return await _suppliesPatientsRepository.UpdateSuppliesPatient(suppliesPatient);
        }

        public async Task<SuppliesPatients> DeleteSuppliesPatient(int SUP_ID)
        {
            return await _suppliesPatientsRepository.DeleteSuppliesPatient(SUP_ID);
        }
    }

    
}

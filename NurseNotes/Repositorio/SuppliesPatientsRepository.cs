using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ISuppliesPatientsRepository
    {
        Task<List<SuppliesPatients>> GetAll();
        Task<SuppliesPatients> GetSuppliesPatient(int SUP_ID);
        Task<SuppliesPatients> CreateSuppliesPatient(int SUP_ID, int CANTSUP, int ICNOME_ID, int MED_ID);
        Task<SuppliesPatients> GetSuppliesPatientByCantSup(int CANTSUP);
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

        public Task<SuppliesPatients> CreateSuppliesPatient(int SUP_ID, int CANTSUP, int ICNOME_ID, int MED_ID)
        {
            throw new NotImplementedException();
        }

        public Task<SuppliesPatients> DeleteSuppliesPatient(int SUP_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<SuppliesPatients>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SuppliesPatients> GetSuppliesPatient(int SUP_ID)
        {
            throw new NotImplementedException();
        }

        public Task<SuppliesPatients> GetSuppliesPatientByCantSup(int CANTSUP)
        {
            throw new NotImplementedException();
        }

        public Task<SuppliesPatients> UpdateSuppliesPatient(SuppliesPatients suppliesPatients)
        {
            throw new NotImplementedException();
        }
    }
}

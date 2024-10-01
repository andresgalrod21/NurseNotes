

using NurseNotes.Context;
using NurseNotes.Model;

namespace Medication.repositorio
{
    public interface IMedicationRepository
    {
        Task<List<Medication>> GetAll();
        Task<Medication> GetMedication(int MED_ID);
        Task<Medication> CreateMedication(int MED_ID, string MEDDSC, int STOCK);
        Task<Medication> UpdateMedication(Medication medication);
        Task<Medication> DeleteMedication(int MED_ID);
    }
}



    public class MedicationRepository : IMedicationRepository
    {
        private readonly TestDbNurseNotes _db;

        public MedicationRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public  Task<Medication> CreateMedication(int MED_ID, string MEDDSC, int STOCK)
        {
        throw new NotImplementedException();
    }

        public  Task<Medication> UpdateMedication(Medication medication)
        {
        _      throw new NotImplementedException();
    }

        public  Task<Medication> DeleteMedication(int MED_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<Medication> GetMedication(int MED_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<List<Medication>> GetAll()
        {
        throw new NotImplementedException();
    }
     
}


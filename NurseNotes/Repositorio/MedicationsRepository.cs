using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IMedicationsRepository
    {
        Task<List<Medications>> GetAll();
        Task<Medications> GetMedication(int USR_ID);
        Task<Medications> CreateMedication(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION);
        Task<Medications> GetMedicationByDocument(int NUMDOC);
        Task<Medications> UpdateMedication(Medications Medications);
        Task<Medications> DeleteMedication(int USR_ID);

    }
    public class MedicationsRepository : IMedicationsRepository
    {
        private readonly TestDbNurseNotes _db;
        public MedicationsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Medications> CreateMedication(int USR_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, string USRPSW, string USR, DateTime FCHCREATION)
        {
            throw new NotImplementedException();
        }

        public Task<Medications> DeleteMedication(int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Medications>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Medications> GetMedication(int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Medications> GetMedicationByDocument(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<Medications> UpdateMedication(Medications Medications)
        {
            throw new NotImplementedException();
        }
    }
}

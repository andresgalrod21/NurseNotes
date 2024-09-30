using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPatientsRepository
    {
        Task<List<Patients>> GetAll();
        Task<Patients> GetPatient(int PATIENT_ID);
        Task<Patients> CreatePatient(int PATIENT_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, int AGE, int NUMCONTACT, string? MAIL);
        Task<Patients> GetPatientByDocument(int NUMDOC);
        Task<Patients> CreatePatient(Patients patients, string NAME, string LASTNAME);
        Task<Patients> UpdatePatient(Patients patients);
        Task<Patients> DeletePatient(int PATIENT_ID);

    }
    public class PatientsRepository : IPatientsRepository
    {
        private readonly TestDbNurseNotes _db;
        public PatientsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Patients> CreatePatient(int PATIENT_ID, string NAME, string LASTNAME, string TIPDOC, int NUMDOC, int AGE, int NUMCONTACT, string? MAIL)
        {
            throw new NotImplementedException();
        }

        public Task<Patients> CreatePatient(Patients patients, string NAME, string LASTNAME)
        {
            throw new NotImplementedException();
        }

        public Task<Patients> DeletePatient(int PATIENT_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Patients>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Patients> GetPatient(int PATIENT_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Patients> GetPatientByDocument(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<Patients> UpdatePatient(Patients patients)
        {
            throw new NotImplementedException();
        }
    }
}

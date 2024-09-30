using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPatientRecordsRepository
    {
        Task<List<PatientRecords>> GetAll();
        Task<PatientRecords> GetPatientRecord(int PATR_ID);
        Task<PatientRecords> CreatePatientRecord(int PATR_ID, string RH, bool? ALLERGIES, string? ALLERG_DSC, bool? SURGERIES, string? SURGER_DSC, int INCOME_ID);
        Task<PatientRecords> GetPatientRecordByRH(int RH);
        Task<PatientRecords> CreatePatientRecord(PatientRecords patientRecords, string RH);
        Task<PatientRecords> UpdatePatientRecord(PatientRecords patientRecords);
        Task<PatientRecords> DeletePatientRecord(int PATR_ID);
    }
    public class PatientRecordsRepository : IPatientRecordsRepository
    {
        private readonly TestDbNurseNotes _db;
        public PatientRecordsRepository(TestDbNurseNotes db) 
        { 
            _db = db;
        }

        public Task<PatientRecords> CreatePatientRecord(int PATR_ID, string RH, bool? ALLERGIES, string? ALLERG_DSC, bool? SURGERIES, string? SURGER_DSC, int INCOME_ID)
        {
            throw new NotImplementedException();
        }

        public Task<PatientRecords> CreatePatientRecord(PatientRecords patientRecords, string RH)
        {
            throw new NotImplementedException();
        }

        public Task<PatientRecords> DeletePatientRecord(int PATR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<PatientRecords>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PatientRecords> GetPatientRecord(int PATR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<PatientRecords> GetPatientRecordByRH(int RH)
        {
            throw new NotImplementedException();
        }

        public Task<PatientRecords> UpdatePatientRecord(PatientRecords patientRecords)
        {
            throw new NotImplementedException();
        }
    }
}

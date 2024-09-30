using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPatientRecordsRepository
    {
        Task<IEnumerable<PatientRecords>> getallsubjectsAsync();
        Task<PatientRecords> getsubjectbyIdAsync(int PATR_ID);
        Task CreatePatientRecordsAsync(PatientRecords PatientRecords);
        Task UpdatePatientRecordsAsync(PatientRecords PatientRecords);
        Task SoftDeletePatientRecordsAsync(PatientRecords PatientRecords);
    }
    public class PatientRecordsRepository
    {
        public PatientRecordsRepository() 
        { 
        }

        public Task CreatePatientRecordsAsync(PatientRecords PatientRecords)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PatientRecords>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PatientRecords> getsubjectbyIdAsync(int PATR_ID)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeletePatientRecordsAsync(PatientRecords PatientRecords)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatientRecordsAsync(PatientRecords PatientRecords)
        {
            throw new NotImplementedException();
        }
    }
}

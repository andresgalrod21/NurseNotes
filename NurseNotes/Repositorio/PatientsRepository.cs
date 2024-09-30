using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPatientsRepository
    {
        Task<IEnumerable<Patients>> getallsubjectsAsync();
        Task<Patients> getsubjectbyIdAsync(int PATIENT_ID);
        Task CreatePatientsAsync(Patients Patients);
        Task UpdatePatientsAsync(Patients Patients);
        Task SoftDeletePatientsAsync(Patients Patients);
    }
    public class PatientsRepository
    {
        public PatientsRepository()
        {
        }

        public Task CreatePatientsAsync(Patients Patients)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patients>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Patients> getsubjectbyIdAsync(int PATIENT_ID)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeletePatientsAsync(Patients Patients)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatientsAsync(Patients Patients)
        {
            throw new NotImplementedException();
        }
    }
}

using NurseNotes.Model;
using System.Security.Cryptography.X509Certificates;

namespace NurseNotes.NewFolder
{
    public interface IDiagnosisService
    {
        Task<IEnumerable<Diagnosis>> GetAllDiagnosisAsync();
        Task<Diagnosis> GetDiagnosisByIdAsync(int id);
        Task CreateDiagnosisAsync(Diagnosis diagnosis);
        Task UpdateDiagnosisAsync(Diagnosis diagnosis);
        Task SoftDeleteDiagnosisAsync(int id);
    }

    public class DiagnosisService : IDiagnosisService
    {
        public Task CreateDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Diagnosis>> GetAllDiagnosisAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Diagnosis> GetDiagnosisByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteDiagnosisAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDiagnosisAsync(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }
    }
}

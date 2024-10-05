using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IDiagnosisRepository
    {
        Task<List<Diagnosis>> GetAll();
        Task<Diagnosis> GetDiagn(int DIAG_ID);
        Task<Diagnosis> CreateDiagn(int DIAG_ID, string DIAGDSC);
        Task<Diagnosis> GetDiagnByDiagDsc(int DIAGDSC);
        Task<Diagnosis> UpdateDiagn(Diagnosis diagnosis);
        Task<Diagnosis> DeleteDiagn(int DIAG_ID);
    }
    public class DiagnosisRepository : IDiagnosisRepository
    {
        private readonly TestDbNurseNotes _db;
        public DiagnosisRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Diagnosis> CreateDiagn(int DIAG_ID, string DIAGDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Diagnosis> DeleteDiagn(int DIAG_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Diagnosis>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Diagnosis> GetDiagn(int DIAG_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Diagnosis> GetDiagnByDiagDsc(int DIAGDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Diagnosis> UpdateDiagn(Diagnosis diagnosis)
        {
            throw new NotImplementedException();
        }
    }
}

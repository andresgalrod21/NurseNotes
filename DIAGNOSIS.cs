
using NurseNotes.Context;
using NurseNotes.Model;

namespace Diagnosis.repositorio
{
    public interface IDiagnosisRepository
    {
        Task<List<Diagnosis>> GetAll();
        Task<Diagnosis> GetDiagnosis(int DIAG_ID);
        Task<Diagnosis> CreateDiagnosis(int DIAG_ID, string DIAGDSC);
        Task<Diagnosis> UpdateDiagnosis(Diagnosis diagnosis);
        Task<Diagnosis> DeleteDiagnosis(int DIAG_ID);
    }
}

    public class DiagnosisRepository : IDiagnosisRepository
    {
        private readonly TestDbNurseNotes _db;

        public DiagnosisRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<Diagnosis> CreateDiagnosis(int DIAG_ID, string DIAGDSC)
        {
        throw new NotImplementedException();
    }

        public async Task<Diagnosis> UpdateDiagnosis(Diagnosis diagnosis)
        {
        throw new NotImplementedException();
    }

        public async Task<Diagnosis> DeleteDiagnosis(int DIAG_ID)
        {
        throw new NotImplementedException();
    }

        public async Task<Diagnosis> GetDiagnosis(int DIAG_ID)
        {
        throw new NotImplementedException();
    }

        public async Task<List<Diagnosis>> GetAll()
        {
        throw new NotImplementedException();
    }
    }
}
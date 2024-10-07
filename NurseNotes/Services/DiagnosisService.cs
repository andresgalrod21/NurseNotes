using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IDiagnosisService
    {
        Task<List<Diagnosis>> GetAll();
        Task<Diagnosis> GetDiagn(int DIAG_ID);
        Task<Diagnosis> CreateDiagn(Diagnosis diagnosi);
        Task<Diagnosis> UpdateDiagn(Diagnosis diagnosi);
        Task<Diagnosis> DeleteDiagn(int DIAG_ID);
    }
    public class DiagnosisService : IDiagnosisService
    {
        private readonly IDiagnosisRepository _diagnosisRepository;

        public DiagnosisService(IDiagnosisRepository diagnosisRepository)
        {
            _diagnosisRepository = diagnosisRepository;
        }

        public async Task<List<Diagnosis>> GetAll()
        {
            return await _diagnosisRepository.GetAll();
        }

        public async Task<Diagnosis> GetDiagn(int DIAG_ID)
        {
            return await _diagnosisRepository.GetDiagn(DIAG_ID);
        }

        public async Task<Diagnosis> CreateDiagn(Diagnosis diagnosis)
        {
            return await _diagnosisRepository.CreateDiagn(
                diagnosis.DIAG_ID, diagnosis.DIAGDSC);
        }

        public async Task<Diagnosis> UpdateDiagn(Diagnosis diagnosis)
        {
            return await _diagnosisRepository.UpdateDiagn(diagnosis);
        }

        public async Task<Diagnosis> DeleteDiagn(int DIAG_ID)
        {
            return await _diagnosisRepository.DeleteDiagn(DIAG_ID);
        }
    }
}

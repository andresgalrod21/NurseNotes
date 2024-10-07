using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IPatientRecordsService
    {
        Task<List<PatientRecords>> GetAll();
        Task<PatientRecords> GetPatientRecord(int PATR_ID);
        Task<PatientRecords> CreatePatientRecord(PatientRecords patientRecord);
        Task<PatientRecords> UpdatePatientRecord(PatientRecords patientRecord);
        Task<PatientRecords> DeletePatientRecord(int PATR_ID);
    }
    public class PatientRecordsService : IPatientRecordsService
    {
        private readonly IPatientRecordsRepository _patientRecordsRepository;

        public PatientRecordsService(IPatientRecordsRepository patientRecordsRepository)
        {
            _patientRecordsRepository = patientRecordsRepository;
        }

        public async Task<List<PatientRecords>> GetAll()
        {
            return await _patientRecordsRepository.GetAll();
        }

        public async Task<PatientRecords> GetPatientRecord(int PATR_ID)
        {
            return await _patientRecordsRepository.GetPatientRecord(PATR_ID);
        }

        public async Task<PatientRecords> CreatePatientRecord(PatientRecords patientRecord)
        {
            return await _patientRecordsRepository.CreatePatientRecord(
                patientRecord.PATR_ID, patientRecord.RH, patientRecord.ALLERGIES,
                patientRecord.ALLERG_DSC, patientRecord.SURGERIES, patientRecord.SURGER_DSC,
                patientRecord.INCOME_ID);
        }

        public async Task<PatientRecords> UpdatePatientRecord(PatientRecords patientRecord)
        {
            return await _patientRecordsRepository.UpdatePatientRecord(patientRecord);
        }

        public async Task<PatientRecords> DeletePatientRecord(int PATR_ID)
        {
            return await _patientRecordsRepository.DeletePatientRecord(PATR_ID);
        }
    }
}

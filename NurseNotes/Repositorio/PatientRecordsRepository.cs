using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPatientRecordsRepository
    {
        Task<List<PatientRecords>> GetAll();
        Task<PatientRecords> GetPatientRecord(int PATR_ID);
        Task<PatientRecords> CreatePatientRecord(int PATR_ID, string RH, bool? ALLERGIES, string? ALLERG_DSC, bool? SURGERIES, string? SURGER_DSC, int INCOME_ID);
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

        public async Task<List<PatientRecords>> GetAll()
        {
            return await _db.PatientRecords.ToListAsync();
        }

        public async Task<PatientRecords> GetPatientRecord(int PATR_ID)
        {
            return await _db.PatientRecords.FirstOrDefaultAsync(pr => pr.PATR_ID == PATR_ID);
        }

        public async Task<PatientRecords> CreatePatientRecord(int PATR_ID, string RH, bool? ALLERGIES, string? ALLERG_DSC, bool? SURGERIES, string? SURGER_DSC, int INCOME_ID)
        {
            Incomes Incomes = await _db.Incomes.FindAsync(INCOME_ID);
            if (Incomes == null)
            {
                throw new Exception("Income not found");
            }

            PatientRecords newPatientRecord = new PatientRecords
            {
                PATR_ID = PATR_ID,
                RH = RH,
                ALLERGIES = ALLERGIES,
                ALLERG_DSC = ALLERG_DSC,
                SURGERIES = SURGERIES,
                SURGER_DSC = SURGER_DSC,
                INCOME_ID = INCOME_ID,
                Incomes = Incomes
            };

            await _db.PatientRecords.AddAsync(newPatientRecord);
            await _db.SaveChangesAsync();

            return newPatientRecord;
        }

        public async Task<PatientRecords> UpdatePatientRecord(PatientRecords patientRecords)
        {
            _db.PatientRecords.Update(patientRecords);
            await _db.SaveChangesAsync();
            return patientRecords;
        }

        public async Task<PatientRecords> DeletePatientRecord(int PATR_ID)
        {
            PatientRecords patientRecords = await GetPatientRecord(PATR_ID);
            _db.PatientRecords.Remove(patientRecords);
            await _db.SaveChangesAsync();

            return patientRecords;
        }
    }
}

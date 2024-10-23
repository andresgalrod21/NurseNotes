using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IDiagnosisRepository
    {
        Task<List<Diagnosis>> GetAll();
        Task<Diagnosis> GetDiagn(int DIAG_ID);
        Task<Diagnosis> CreateDiagn(int DIAG_ID, string DIAGDSC);
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

        public async Task<List<Diagnosis>> GetAll()
        {
            return await _db.Diagnosis.ToListAsync();
        }

        public async Task<Diagnosis> GetDiagn(int DIAG_ID)
        {
            return await _db.Diagnosis.FirstOrDefaultAsync(d => d.DIAG_ID == DIAG_ID);
        }

        public async Task<Diagnosis> CreateDiagn(int DIAG_ID, string DIAGDSC)
        {
            Diagnosis newDiagnosis = new Diagnosis
            {
                DIAG_ID = DIAG_ID,
                DIAGDSC = DIAGDSC
            };

            await _db.Diagnosis.AddAsync(newDiagnosis);
            await _db.SaveChangesAsync();

            return newDiagnosis;
        }

        public async Task<Diagnosis> UpdateDiagn(Diagnosis diagnosis)
        {
            var existingDiagnosis = await _db.Diagnosis.FirstOrDefaultAsync(d => d.DIAG_ID == diagnosis.DIAG_ID);

            if (existingDiagnosis == null)
            {
                throw new Exception("Diagnosis cannot be updated. Diagnosis not found.");
            }

            existingDiagnosis.DIAGDSC = diagnosis.DIAGDSC; // Solo actualiza los campos necesarios
            _db.Diagnosis.Update(existingDiagnosis);
            await _db.SaveChangesAsync();

            return existingDiagnosis;
        }

        public async Task<Diagnosis> DeleteDiagn(int DIAG_ID)
        {
            Diagnosis diagnosis = await GetDiagn(DIAG_ID);            
            _db.Diagnosis.Remove(diagnosis);
            await _db.SaveChangesAsync();
            
            return diagnosis;
        }
    }
}

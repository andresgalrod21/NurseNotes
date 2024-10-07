using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPatientsRepository
    {
        Task<List<Patients>> GetAll();
        Task<Patients> GetPatient(int PATIENT_ID);
        Task<Patients> CreatePatient(int PATIENT_ID, string NAME, string LASTNAME, int TIPDOC_ID, int NUMDOC, int AGE, int NUMCONTACT, string? MAIL);
        Task<Patients> UpdatePatient(Patients patients);
        Task<Patients> DeletePatient(int PATIENT_ID);

    }
    public class PatientsRepository : IPatientsRepository
    {
        private readonly TestDbNurseNotes _db;
        public PatientsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Patients>> GetAll()
        {
            return await _db.Patients.ToListAsync();
        }

        public async Task<Patients> GetPatient(int PATIENT_ID)
        {
            return await _db.Patients.FirstOrDefaultAsync(p => p.PATIENT_ID == PATIENT_ID);
        }

        public async Task<Patients> CreatePatient(int PATIENT_ID, string NAME, string LASTNAME, int TIPDOC_ID, int NUMDOC, int AGE, int NUMCONTACT, string? MAIL)
        {
            TipDocs Tipdocs = await _db.TipDocs.FindAsync(PATIENT_ID);
            if (Tipdocs == null)
            {
                throw new Exception("Tipdoc not found");
            }

            Patients newPatient = new Patients
            {
                PATIENT_ID = PATIENT_ID,
                NAME = NAME,
                LASTNAME = LASTNAME,
                TIPDOC_ID = TIPDOC_ID,
                NUMDOC = NUMDOC,
                AGE = AGE,
                NUMCONTACT = NUMCONTACT,
                MAIL = MAIL,
                TipDocs = Tipdocs
            };

            await _db.Patients.AddAsync(newPatient);
            await _db.SaveChangesAsync();

            return newPatient;
        }

        public async Task<Patients> UpdatePatient(Patients patients)
        {
            _db.Patients.Update(patients);
            await _db.SaveChangesAsync();
            return patients;
        }

        public async Task<Patients> DeletePatient(int PATIENT_ID)
        {
            Patients patients = await GetPatient(PATIENT_ID);
            _db.Patients.Remove(patients);
            await _db.SaveChangesAsync();

            return patients;
        }
    }
}

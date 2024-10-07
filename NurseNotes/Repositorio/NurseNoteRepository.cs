using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface INurseNoteRepository
    {
        Task<List<NurseNote>> GetAll();
        Task<NurseNote> GetNote(int NOTE_ID);
        Task<NurseNote> CreateNote(int NOTE_ID, int INCOME_ID, int PATIENT_ID, string REASONCONS, int DIAG_ID, int SPEC_ID, int USR_ID, int STAFF_ID);
        Task<NurseNote> UpdateNote(NurseNote nurseNote);
        Task<NurseNote> DeleteNote(int NOTE_ID);
    }
    public class NurseNoteRepository : INurseNoteRepository
    {
        private readonly TestDbNurseNotes _db;

        public NurseNoteRepository(TestDbNurseNotes DB)
        {
            _db = DB;
        }

        public async Task<List<NurseNote>> GetAll()
        {
            return await _db.NurseNotes.ToListAsync();
        }

        public async Task<NurseNote> GetNote(int NOTE_ID)
        {
            return await _db.NurseNotes.FirstOrDefaultAsync(nn => nn.NOTE_ID == NOTE_ID);
        }

        public async Task<NurseNote> CreateNote(int NOTE_ID, int INCOME_ID, int PATIENT_ID, string REASONCONS, int DIAG_ID, int SPEC_ID, int USR_ID, int STAFF_ID)
        {
            Incomes Incomes = await _db.Incomes.FindAsync(INCOME_ID);
            if (Incomes == null)
            {
                throw new Exception("Income not found");
            }

            Patients Patients = await _db.Patients.FindAsync(PATIENT_ID);
            if (Patients == null)
            {
                throw new Exception("Patient not found");
            }

            Diagnosis Diagnosis = await _db.Diagnosis.FindAsync(DIAG_ID);
            if (Diagnosis == null)
            {
                throw new Exception("Diagnosis not found");
            }

            Specialities Specialities = await _db.Specialities.FindAsync(SPEC_ID);
            if (Specialities == null)
            {
                throw new Exception("Specialitie not found");
            }

            Users Users = await _db.Users.FindAsync(USR_ID);
            if (Users == null)
            {
                throw new Exception("User not found");
            }

            Staff Staff = await _db.Staff.FindAsync(STAFF_ID);
            if (Staff == null)
            {
                throw new Exception("Staff not found");
            }

            NurseNote newNurseNote = new NurseNote
            {
                NOTE_ID = NOTE_ID,
                INCOME_ID = INCOME_ID,
                PATIENT_ID = PATIENT_ID,
                REASONCONS = REASONCONS,
                DIAG_ID = DIAG_ID,
                SPEC_ID = SPEC_ID,
                USR_ID = USR_ID,
                STAFF_ID = STAFF_ID,
                Incomes = Incomes,
                Patients = Patients,
                Diagnosis = Diagnosis,
                Specialities = Specialities,
                Users = Users,
                Staff = Staff
            };

            await _db.NurseNotes.AddAsync(newNurseNote);
            await _db.SaveChangesAsync();

            return newNurseNote;
        }

        public async Task<NurseNote> UpdateNote(NurseNote nurseNote)
        {
            _db.NurseNotes.Update(nurseNote);
            await _db.SaveChangesAsync();
            return nurseNote;
        }

        public async Task<NurseNote> DeleteNote(int NOTE_ID)
        {
            NurseNote nurseNote = await GetNote(NOTE_ID);
            _db.NurseNotes.Remove(nurseNote);
            await _db.SaveChangesAsync();

            return nurseNote;
        }
    }
}

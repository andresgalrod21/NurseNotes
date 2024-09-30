using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface INurseNoteRepository
    {
        Task<List<NurseNote>> GetAll();
        Task<NurseNote> GetNote(int NOTE_ID);
        Task<NurseNote> CreateNote(int NOTE_ID, int INCOME_ID, int PATIENT_ID, string REASONCONS, int DIAG_ID, int SPEC_ID, int USR_ID, int STAFF_ID);
        Task<NurseNote> GetNoteByDocument(int NUMDOC);
        Task<NurseNote> CreateNote(NurseNote nurseNote, string REASONCONS);
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

        public Task<NurseNote> CreateNote(int NOTE_ID, int INCOME_ID, int PATIENT_ID, string REASONCONS, int DIAG_ID, int SPEC_ID, int USR_ID, int STAFF_ID)
        {
            throw new NotImplementedException();
        }

        public Task<NurseNote> CreateNote(NurseNote nurseNote, string REASONCONS)
        {
            throw new NotImplementedException();
        }

        public Task<NurseNote> DeleteNote(int NOTE_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<NurseNote>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<NurseNote> GetNote(int NOTE_ID)
        {
            throw new NotImplementedException();
        }

        public Task<NurseNote> GetNoteByDocument(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<NurseNote> UpdateNote(NurseNote nurseNote)
        {
            throw new NotImplementedException();
        }
    }
}

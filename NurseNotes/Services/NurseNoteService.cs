using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface INurseNoteService
    {
        Task<List<NurseNote>> GetAll();
        Task<NurseNote> GetNote(int NOTE_ID);
        Task<NurseNote> CreateNote(NurseNote nurseNote);
        Task<NurseNote> UpdateNote(NurseNote nurseNote);
        Task<NurseNote> DeleteNote(int NOTE_ID);
    }
    public class NurseNoteService : INurseNoteService
    {
        private readonly INurseNoteRepository _nurseNoteRepository;

        public NurseNoteService(INurseNoteRepository nurseNoteRepository)
        {
            _nurseNoteRepository = nurseNoteRepository;
        }

        public async Task<List<NurseNote>> GetAll()
        {
            return await _nurseNoteRepository.GetAll();
        }

        public async Task<NurseNote> GetNote(int NOTE_ID)
        {
            return await _nurseNoteRepository.GetNote(NOTE_ID);
        }

        public async Task<NurseNote> CreateNote(NurseNote nurseNote)
        {
            return await _nurseNoteRepository.CreateNote(
                nurseNote.NOTE_ID, nurseNote.INCOME_ID, nurseNote.PATIENT_ID,
                nurseNote.REASONCONS, nurseNote.DIAG_ID, nurseNote.SPEC_ID,
                nurseNote.USR_ID, nurseNote.STAFF_ID);
        }

        public async Task<NurseNote> UpdateNote(NurseNote nurseNote)
        {
            return await _nurseNoteRepository.UpdateNote(nurseNote);
        }

        public async Task<NurseNote> DeleteNote(int NOTE_ID)
        {
            return await _nurseNoteRepository.DeleteNote(NOTE_ID);
        }
    }
}

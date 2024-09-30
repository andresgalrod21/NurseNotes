using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface INurseNoteRepository
    {
        Task<IEnumerable<NurseNote>> getallsubjectsAsync();
        Task<NurseNote> getsubjectbyIdAsync(int NOTE_ID);
        Task CreateNurseNoteAsync(NurseNote NurseNote);
        Task UpdateNurseNoteAsync(NurseNote NurseNote);
        Task SoftDeleteNurseNoteAsync(NurseNote NurseNote);
    }
    public class NurseNoteRepository
    {
        public NurseNoteRepository()
        {
        }

        public Task CreateNurseNoteAsync(NurseNote NurseNote)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NurseNote>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NurseNote> getsubjectbyIdAsync(int NOTE_ID)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteNurseNoteAsync(NurseNote NurseNote)
        {
            throw new NotImplementedException();
        }

        public Task UpdateNurseNoteAsync(NurseNote NurseNote)
        {
            throw new NotImplementedException();
        }
    }
}

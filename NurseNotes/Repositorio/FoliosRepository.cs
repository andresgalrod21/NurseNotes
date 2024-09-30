using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IFoliosRepository
    {
        Task<IEnumerable<Folios>> getallsubjectsAsync();
        Task<Folios> getsubjectbyIdAsync(int FOLIO_ID);
        Task CreateFoliosAsync(Folios Folios);
        Task UpdateFoliosAsync(Folios Folios);
        Task SoftDeleteFoliosAsync(Folios Folios);
    }
    public class FoliosRepository
    {
        public FoliosRepository()
        {
        }

        public Task CreateFoliosAsync(Folios Folios)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Folios>> getallsubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Folios> getsubjectbyIdAsync(int FOLIO_ID)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteFoliosAsync(Folios Folios)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFoliosAsync(Folios Folios)
        {
            throw new NotImplementedException();
        }
    }
}

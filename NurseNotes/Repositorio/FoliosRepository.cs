using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IFoliosRepository
    {
        Task<List<Folios>> GetAll();
        Task<Folios> GetFolio(int FOLIO_ID);
        Task<Folios> CreateFolio(int FOLIO_ID, int INCOME_ID, int NOTE_ID, /*int SUP_ID,*/ int USR_ID, string? EVOLUTION);
        Task<Folios> GetFolioByDocument(int NOTE_ID);
        Task<Folios> CreateFolio(Folios folios, string EVOLUTION);
        Task<Folios> UpdateFolio(Folios folios);
        Task<Folios> DeleteFolio(int FOLIO_ID);
    }
    public class FoliosRepository : IFoliosRepository
    {
        private readonly TestDbNurseNotes _db;

        public FoliosRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Folios> CreateFolio(int FOLIO_ID, int INCOME_ID, int NOTE_ID, int USR_ID, string? EVOLUTION)
        {
            throw new NotImplementedException();
        }

        public Task<Folios> CreateFolio(Folios folios, string EVOLUTION)
        {
            throw new NotImplementedException();
        }

        public Task<Folios> DeleteFolio(int FOLIO_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Folios>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Folios> GetFolio(int FOLIO_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Folios> GetFolioByDocument(int NOTE_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Folios> UpdateFolio(Folios folios)
        {
            throw new NotImplementedException();
        }
    }
}

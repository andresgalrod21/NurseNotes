using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ITipDocsRepository
    {
        Task<List<TipDocs>> GetAll();
        Task<TipDocs> GetTipDoc(int TIPDOC_ID);
        Task<TipDocs> CreateTipDoc(int TIPDOC_ID, string TIPDOCDSC);
        Task<TipDocs> GetTipDocByTipDocDsc(int TIPDOCDSC);
        Task<TipDocs> UpdateTipDoc(TipDocs tipDocs);
        Task<TipDocs> DeleteTipDoc(int TIPDOC_ID);

    }
    public class TipDocsRepository : ITipDocsRepository
    {
        private readonly TestDbNurseNotes _db;
        public TipDocsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<TipDocs> CreateTipDoc(int TIPDOC_ID, string TIPDOCDSC)
        {
            throw new NotImplementedException();
        }

        public Task<TipDocs> DeleteTipDoc(int TIPDOC_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<TipDocs>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TipDocs> GetTipDoc(int TIPDOC_ID)
        {
            throw new NotImplementedException();
        }

        public Task<TipDocs> GetTipDocByTipDocDsc(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<TipDocs> UpdateTipDoc(TipDocs tipDocs)
        {
            throw new NotImplementedException();
        }
    }
}

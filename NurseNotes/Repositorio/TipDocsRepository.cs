using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ITipDocsRepository
    {
        Task<List<TipDocs>> GetAll();
        Task<TipDocs> GetTipDoc(int TIPDOC_ID);
        Task<TipDocs> CreateTipDoc(int TIPDOC_ID, string TIPDOCDSC);
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

        public async Task<List<TipDocs>> GetAll()
        {
            return await _db.TipDocs.ToListAsync();
        }

        public async Task<TipDocs> GetTipDoc(int TIPDOC_ID)
        {
            return await _db.TipDocs.FirstOrDefaultAsync(doc => doc.TIPDOC_ID == TIPDOC_ID);
        }

        public async Task<TipDocs> CreateTipDoc(int TIPDOC_ID, string TIPDOCDSC)
        {
            TipDocs newTipDoc = new TipDocs
            {
                TIPDOC_ID = TIPDOC_ID,
                TIPDOCDSC = TIPDOCDSC
            };

            await _db.TipDocs.AddAsync(newTipDoc);
            await _db.SaveChangesAsync();

            return newTipDoc;
        }

        public async Task<TipDocs> UpdateTipDoc(TipDocs tipDocs)
        {
            _db.TipDocs.Update(tipDocs);
            await _db.SaveChangesAsync();
            return tipDocs;
        }

        public async Task<TipDocs> DeleteTipDoc(int TIPDOC_ID)
        {
            TipDocs tipDocs = await GetTipDoc(TIPDOC_ID);
            _db.TipDocs.Remove(tipDocs);
            await _db.SaveChangesAsync();
            return tipDocs;
        }
    }
}

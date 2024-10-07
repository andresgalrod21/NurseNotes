using System.Collections.Generic;
using System.Threading.Tasks;
using NurseNotes.Model;
using NurseNotes.Repositorio;

namespace NurseNotes.Services
{
    public interface ITipDocsService
    {
        Task<List<TipDocs>> GetAll();
        Task<TipDocs> GetTipDoc(int TIPDOC_ID);
        Task<TipDocs> CreateTipDoc(TipDocs tipDoc);
        Task<TipDocs> UpdateTipDoc(TipDocs tipDoc);
        Task<TipDocs> DeleteTipDoc(int TIPDOC_ID);

    }
    public class TipDocsService 
    {
        readonly ITipDocsRepository _tipDocsRepository;

        public TipDocsService(ITipDocsRepository tipDocsRepository)
        {
            _tipDocsRepository = tipDocsRepository;
        }

        public async Task<List<TipDocs>> GetAll()
        {
            return await _tipDocsRepository.GetAll();
        }

        public async Task<TipDocs> GetTipDoc(int TIPDOC_ID)
        {
            return await _tipDocsRepository.GetTipDoc(TIPDOC_ID);
        }

        public async Task<TipDocs> CreateTipDoc(TipDocs tipDoc)
        {
            return await _tipDocsRepository.CreateTipDoc(
                tipDoc.TIPDOC_ID, tipDoc.TIPDOCDSC);
        }

        public async Task<TipDocs> UpdateTipDoc(TipDocs tipDoc)
        {
            return await _tipDocsRepository.UpdateTipDoc(tipDoc);
        }

        public async Task<TipDocs> DeleteTipDoc(int TIPDOC_ID)
        {
            return await _tipDocsRepository.DeleteTipDoc(TIPDOC_ID);
        }
    }
}

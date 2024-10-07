using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IFoliosService
    {
        Task<List<Folios>> GetAll();
        Task<Folios> GetFolio(int FOLIO_ID);
        Task<Folios> CreateFolio(Folios folio);
        Task<Folios> UpdateFolio(Folios folio);
        Task<Folios> DeleteFolio(int FOLIO_ID);
    }
    public class FoliosService : IFoliosService
    {
        private readonly IFoliosRepository _foliosRepository;

        public FoliosService(IFoliosRepository foliosRepository)
        {
            _foliosRepository = foliosRepository;
        }

        public async Task<List<Folios>> GetAll()
        {
            return await _foliosRepository.GetAll();
        }

        public async Task<Folios> GetFolio(int FOLIO_ID)
        {
            return await _foliosRepository.GetFolio(FOLIO_ID);
        }

        public async Task<Folios> CreateFolio(Folios folio)
        {
            return await _foliosRepository.CreateFolio(
                folio.FOLIO_ID, folio.INCOME_ID, folio.NOTE_ID,
                folio.SUP_ID, folio.USR_ID, folio.EVOLUTION);
        }

        public async Task<Folios> UpdateFolio(Folios folio)
        {
            return await _foliosRepository.UpdateFolio(folio);
        }

        public async Task<Folios> DeleteFolio(int FOLIO_ID)
        {
            return await _foliosRepository.DeleteFolio(FOLIO_ID);
        }
    }
}

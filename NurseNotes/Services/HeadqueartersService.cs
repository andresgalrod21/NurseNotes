using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IHeadqueartersService
    {
        Task<List<Headquearters>> GetAll();
        Task<Headquearters> GetHeadquearter(int HEADQ_ID);
        Task<Headquearters> CreateHeadquearter(Headquearters headquearter);
        Task<Headquearters> UpdateHeadquearter(Headquearters headquearter);
        Task<Headquearters> DeleteHeadquearter(int HEADQ_ID);

    }
    public class HeadqueartersService : IHeadqueartersService
    {
        private readonly IHeadqueartersRepository _headqueartersRepository;

        public HeadqueartersService(IHeadqueartersRepository headqueartersRepository)
        {
            _headqueartersRepository = headqueartersRepository;
        }

        public async Task<List<Headquearters>> GetAll()
        {
            return await _headqueartersRepository.GetAll();
        }

        public async Task<Headquearters> GetHeadquearter(int HEADQ_ID)
        {
            return await _headqueartersRepository.GetHeadquearter(HEADQ_ID);
        }

        public async Task<Headquearters> CreateHeadquearter(Headquearters headquearter)
        {
            return await _headqueartersRepository.CreateHeadquearter(
                headquearter.HEADQ_ID, headquearter.HEADQDSC);
        }

        public async Task<Headquearters> UpdateHeadquearter(Headquearters headquearter)
        {
            return await _headqueartersRepository.UpdateHeadquearter(headquearter);
        }

        public async Task<Headquearters> DeleteHeadquearter(int HEADQ_ID)
        {
            return await _headqueartersRepository.DeleteHeadquearter(HEADQ_ID);
        }
    }
}

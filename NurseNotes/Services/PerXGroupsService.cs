using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IPerXGroupsService
    {
        Task<List<PerXGroups>> GetAll();
        Task<PerXGroups> GetPerXGroup(int PG_ID);
        Task<PerXGroups> CreatePerXGroup(PerXGroups perXGroup);
        Task<PerXGroups> UpdatePerXGroup(PerXGroups PerXGroup);
        Task<PerXGroups> DeletePerXGroup(int PG_ID);

    }
    public class PerXGroupsService : IPerXGroupsService
    {
        private readonly IPerXGroupsRepository _perXGroupsRepository;

        public PerXGroupsService(IPerXGroupsRepository perXGroupsRepository)
        {
            _perXGroupsRepository = perXGroupsRepository;
        }

        public async Task<List<PerXGroups>> GetAll()
        {
            return await _perXGroupsRepository.GetAll();
        }

        public async Task<PerXGroups> GetPerXGroup(int PG_ID)
        {
            return await _perXGroupsRepository.GetPerXGroup(PG_ID);
        }

        public async Task<PerXGroups> CreatePerXGroup(PerXGroups perXGroup)
        {
            return await _perXGroupsRepository.CreatePerXGroup
                (perXGroup.PG_ID, perXGroup.GRP_ID, perXGroup.PER_ID);
        }

        public async Task<PerXGroups> UpdatePerXGroup(PerXGroups perXGroup)
        {
            return await _perXGroupsRepository.UpdatePerXGroup(perXGroup);
        }

        public async Task<PerXGroups> DeletePerXGroup(int PG_ID)
        {
            return await _perXGroupsRepository.DeletePerXGroup(PG_ID);
        }
    }
}

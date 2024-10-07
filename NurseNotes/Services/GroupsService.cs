using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IGroupsService
    {
        Task<List<Groups>> GetAll();
        Task<Groups> GetGroup(int GRP_ID);
        Task<Groups> CreateGroup(Groups group);
        Task<Groups> UpdateGroup(Groups group);
        Task<Groups> DeleteGroup(int GRP_ID);

    }
    public class GroupsService : IGroupsService
    {
        private readonly IGroupsRepository _groupsRepository;

        public GroupsService(IGroupsRepository groupsRepository)
        {
            _groupsRepository = groupsRepository;
        }

        public async Task<List<Groups>> GetAll()
        {
            return await _groupsRepository.GetAll();
        }

        public async Task<Groups> GetGroup(int GRP_ID)
        {
            return await _groupsRepository.GetGroup(GRP_ID);
        }

        public async Task<Groups> CreateGroup(Groups group)
        {
            return await _groupsRepository.CreateGroup(
                group.GRP_ID, group.GRPDSC);
        }

        public async Task<Groups> UpdateGroup(Groups group)
        {
            return await _groupsRepository.UpdateGroup(group);
        }

        public async Task<Groups> DeleteGroup(int GRP_ID)
        {
            return await _groupsRepository.DeleteGroup(GRP_ID);
        }
    }
}

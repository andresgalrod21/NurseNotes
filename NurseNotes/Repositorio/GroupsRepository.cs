using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IGroupsRepository
    {
        Task<List<Groups>> GetAll();
        Task<Groups> GetGroup(int GRP_ID);
        Task<Groups> CreateGroup(int GRP_ID, string GRPDSC);
        Task<Groups> GetGroupByGrpDsc(int GRPDSC);
        Task<Groups> UpdateGroup(Groups groups);
        Task<Groups> DeleteGroup(int GRP_ID);

    }
    public class GroupsRepository : IGroupsRepository
    {
        private readonly TestDbNurseNotes _db;
        public GroupsRepository(TestDbNurseNotes db)    
        {
            _db = db;
        }

        public Task<Groups> CreateGroup(int GRP_ID, string GRPDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Groups> DeleteGroup(int GRP_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Groups>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Groups> GetGroup(int GRP_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Groups> GetGroupByGrpDsc(int GRPDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Groups> UpdateGroup(Groups groups)
        {
            throw new NotImplementedException();
        }
    }
}

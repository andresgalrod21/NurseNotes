
using NurseNotes.Context;
using NurseNotes.Model;

namespace Groups.repositorio

    {
        public interface IGroupRepository
        {
            Task<List<Group>> GetAll();
            Task<Group> GetGroup(int GRP_ID);
            Task<Group> CreateGroup(int GRP_ID, string GRP´DSC);
            Task<Group> UpdateGroup(Group group);
            Task<Group> DeleteGroup(int GRP_ID);
        }
}


    public class GroupRepository : IGroupRepository
    {
        private readonly TestDbNurseNotes _db;

        public GroupRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public  Task<Group> CreateGroup(int GRP_ID, string GRP´DSC)
        {
        throw new NotImplementedException();
        }

        public  Task<Group> UpdateGroup(Group group)
        {
        throw new NotImplementedException();
        }

        public  Task<Group> DeleteGroup(int GRP_ID)
        {
         throw new NotImplementedException();
        }

        public async Task<Group> GetGroup(int GRP_ID)
        {
        throw new NotImplementedException();
        }

        public async Task<List<Group>> GetAll()
        {
        throw new NotImplementedException();
        }
    }


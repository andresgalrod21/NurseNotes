using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IPerXGroupsRepository
    {
        Task<List<PerXGroups>> GetAll();
        Task<PerXGroups> GetPerXGroup(int PG_ID);
        Task<PerXGroups> CreatePerXGroup(int PG_ID, int GRP_ID, int PER_ID);
        //Task<PerXGroups> GetPerXGroupByXXXX(int );
        Task<PerXGroups> UpdatePerXGroup(PerXGroups PerXGroups);
        Task<PerXGroups> DeletePerXGroup(int PG_ID);

    }
    public class PerXGroupsRepository : IPerXGroupsRepository
    {
        private readonly TestDbNurseNotes _db;
        public PerXGroupsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<PerXGroups> CreatePerXGroup(int PG_ID, int GRP_ID, int PER_ID)
        {
            throw new NotImplementedException();
        }

        public Task<PerXGroups> DeletePerXGroup(int PG_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<PerXGroups>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PerXGroups> GetPerXGroup(int PG_ID)
        {
            throw new NotImplementedException();
        }

        public Task<PerXGroups> UpdatePerXGroup(PerXGroups PerXGroups)
        {
            throw new NotImplementedException();
        }
    }
}

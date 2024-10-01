
using NurseNotes.Context;
using NurseNotes.Model;


namespace PerxGroup.repositorio
{
    public interface IPerXGroupRepository
    {
        Task<List<PerXGroup>> GetAll();
        Task<PerXGroup> GetPerXGroup(int PG_ID);
        Task<PerXGroup> CreatePerXGroup(int PG_ID, int GRP_ID, int PER_ID);
        Task<PerXGroup> UpdatePerXGroup(PerXGroup perXGroup);
        Task<PerXGroup> DeletePerXGroup(int PG_ID);
    }
}


    public class PerXGroupRepository : IPerXGroupRepository
    {
        private readonly TestDbNurseNotes _db;

        public PerXGroupRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public  Task<PerXGroup> CreatePerXGroup(int PG_ID, int GRP_ID, int PER_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<PerXGroup> UpdatePerXGroup(PerXGroup perXGroup)
        {
        throw new NotImplementedException();
    }

        public  Task<PerXGroup> DeletePerXGroup(int PG_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<PerXGroup> GetPerXGroup(int PG_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<List<PerXGroup>> GetAll()
        {
        throw new NotImplementedException();
    }
    }
}
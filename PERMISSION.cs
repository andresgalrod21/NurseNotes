
using NurseNotes.Context;
using NurseNotes.Model;

namespace Permission.repositorio
{
    public interface IPermissionRepository
    {
        Task<List<Permission>> GetAll();
        Task<Permission> GetPermission(int PER_ID);
        Task<Permission> CreatePermission(int PER_ID, string PERDSC);
        Task<Permission> UpdatePermission(Permission permission);
        Task<Permission> DeletePermission(int PER_ID);
    }
}



    public class PermissionRepository : IPermissionRepository
    {
        private readonly TestDbNurseNotes _db;

        public PermissionRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public  Task<Permission> CreatePermission(int PER_ID, string PERDSC)
        {
        throw new NotImplementedException();
    }

        public  Task<Permission> UpdatePermission(Permission permission)
        {
         throw new NotImplementedException();
    }

        public  Task<Permission> DeletePermission(int PER_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<Permission> GetPermission(int PER_ID)
        {
        throw new NotImplementedException();
    }

        public async Task<List<Permission>> GetAll()
        {
        throw new NotImplementedException();
    }
   
}

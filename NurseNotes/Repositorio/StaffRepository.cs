using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IStaffRepository
    {
        Task<List<Staff>> GetAll();
        Task<Staff> GetStaf(int STAFF_ID);
        Task<Staff> CreateStaf(int STAFF_ID, string STAFFDSC, int SPEC_ID, int HEADQ_ID, int USR_ID);
        Task<Staff> GetStafByStaffDsc(int STAFFDSC);
        Task<Staff> UpdateStaf(Staff Staff);
        Task<Staff> DeleteStaf(int STAFF_ID);

    }
    public class StaffRepository : IStaffRepository
    {
        private readonly TestDbNurseNotes _db;
        public StaffRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Staff> CreateStaf(int STAFF_ID, string STAFFDSC, int SPEC_ID, int HEADQ_ID, int USR_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Staff> DeleteStaf(int STAFF_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Staff>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Staff> GetStaf(int STAFF_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Staff> GetStafByStaffDsc(int NUMDOC)
        {
            throw new NotImplementedException();
        }

        public Task<Staff> UpdateStaf(Staff Staff)
        {
            throw new NotImplementedException();
        }
    }
}

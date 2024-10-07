using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IStaffRepository
    {
        Task<List<Staff>> GetAll();
        Task<Staff> GetStaf(int STAFF_ID);
        Task<Staff> CreateStaf(int STAFF_ID, string MEDSTAFF, int SPEC_ID, int HEADQ_ID, int USR_ID);
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

        public async Task<List<Staff>> GetAll()
        {
            return await _db.Staff.ToListAsync();
        }

        public async Task<Staff> GetStaf(int STAFF_ID)
        {
            return await _db.Staff.FirstOrDefaultAsync(s => s.STAFF_ID == STAFF_ID);
        }

        public async Task<Staff> CreateStaf(int STAFF_ID, string MEDSTAFF, int SPEC_ID, int HEADQ_ID, int USR_ID)
        {
            Specialities Specialities = await _db.Specialities.FindAsync(SPEC_ID);
            if (Specialities == null)
            {
                throw new Exception("Specialitie not found");
            }

            Headquearters Headquearters = await _db.Headquearters.FindAsync(HEADQ_ID);
            if (Headquearters == null)
            {
                throw new Exception("Headquearter not found");
            }

            Users Users = await _db.Users.FindAsync(USR_ID);
            if (Users == null)
            {
                throw new Exception("User not found");
            }

            Staff newStaff = new Staff
            {
                STAFF_ID = STAFF_ID,
                MEDSTAFF = MEDSTAFF,
                SPEC_ID = SPEC_ID,
                HEADQ_ID = HEADQ_ID,
                USR_ID = USR_ID,
                Specialities = Specialities,
                Headquearters = Headquearters,
                Users = Users
            };

            await _db.Staff.AddAsync(newStaff);
            await _db.SaveChangesAsync();

            return newStaff;
        }

        public async Task<Staff> UpdateStaf(Staff staff)
        {
            _db.Staff.Update(staff);
            await _db.SaveChangesAsync();
            return staff;
        }

        public async Task<Staff> DeleteStaf(int STAFF_ID)
        {
            Staff staff = await GetStaf(STAFF_ID);
            _db.Staff.Remove(staff);
            await _db.SaveChangesAsync();

            return staff;
        }

    }
}

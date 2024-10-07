using System.Collections.Generic;
using System.Threading.Tasks;
using NurseNotes.Model;
using NurseNotes.Repositorio;

namespace NurseNotes.Services
{
    public interface IStaffService
    {
        Task<List<Staff>> GetAll();
        Task<Staff> GetStaf(int STAFF_ID);
        Task<Staff> CreateStaf(Staff staff);
        Task<Staff> UpdateStaf(Staff staff);
        Task<Staff> DeleteStaf(int STAFF_ID);

    }
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;

        public StaffService(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public async Task<List<Staff>> GetAll()
        {
            return await _staffRepository.GetAll();
        }

        public async Task<Staff> GetStaf(int STAFF_ID)
        {
            return await _staffRepository.GetStaf(STAFF_ID);
        }

        public async Task<Staff> CreateStaf(Staff staff)
        {
            return await _staffRepository.CreateStaf(
                staff.STAFF_ID, staff.MEDSTAFF, staff.SPEC_ID,
                staff.HEADQ_ID, staff.USR_ID);
        }

        public async Task<Staff> UpdateStaf(Staff staff)
        {
            return await _staffRepository.UpdateStaf(staff);
        }

        public async Task<Staff> DeleteStaf(int STAFF_ID)
        {
            return await _staffRepository.DeleteStaf(STAFF_ID);
        }
    }
}

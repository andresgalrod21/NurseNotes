using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IPermitionsService
    {
        Task<List<Permitions>> GetAll();
        Task<Permitions> GetPermition(int PER_ID);
        Task<Permitions> CreatePermition(Permitions permition);
        Task<Permitions> UpdatePermition(Permitions permition);
        Task<Permitions> DeletePermition(int PER_ID);

    }
    public class PermitionsService : IPermitionsService
    {
        private readonly IPermitionsRepository _permitionsRepository;

        public PermitionsService(IPermitionsRepository permitionsRepository)
        {
            _permitionsRepository = permitionsRepository;
        }

        public async Task<List<Permitions>> GetAll()
        {
            return await _permitionsRepository.GetAll();
        }

        public async Task<Permitions> GetPermition(int PER_ID)
        {
            return await _permitionsRepository.GetPermition(PER_ID);
        }

        public async Task<Permitions> CreatePermition(Permitions permition)
        {
            return await _permitionsRepository.CreatePermition(
                permition.PER_ID, permition.PERDSC);
        }

        public async Task<Permitions> UpdatePermition(Permitions permition)
        {
            return await _permitionsRepository.UpdatePermition(permition);
        }

        public async Task<Permitions> DeletePermition(int PER_ID)
        {
            return await _permitionsRepository.DeletePermition(PER_ID);
        }
    }
}

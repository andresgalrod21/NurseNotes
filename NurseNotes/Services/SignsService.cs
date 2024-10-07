using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface ISignsService
    {
        Task<List<Signs>> GetAll();
        Task<Signs> GetSign(int SIGN_ID);
        Task<Signs> CreateSign(Signs sign);
        Task<Signs> UpdateSign(Signs sign);
        Task<Signs> DeleteSign(int SIGN_ID);

    }
    public class SignsService : ISignsService
    {
        private readonly ISignsRepository _signsRepository;

        public SignsService(ISignsRepository signsRepository)
        {
            _signsRepository = signsRepository;
        }

        public async Task<List<Signs>> GetAll()
        {
            return await _signsRepository.GetAll();
        }

        public async Task<Signs> GetSign(int SIGN_ID)
        {
            return await _signsRepository.GetSign(SIGN_ID);
        }

        public async Task<Signs> CreateSign(Signs sign)
        {
            return await _signsRepository.CreateSign(
                sign.SIGN_ID, sign.NOTE_ID, sign.TEMPERATURE, sign.PULSE);
        }

        public async Task<Signs> UpdateSign(Signs sign)
        {
            return await _signsRepository.UpdateSign(sign);
        }

        public async Task<Signs> DeleteSign(int SIGN_ID)
        {
            return await _signsRepository.DeleteSign(SIGN_ID);
        }
    }
}

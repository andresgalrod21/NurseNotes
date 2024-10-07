using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface ISpecialitiesService
    {
        Task<List<Specialities>> GetAll();
        Task<Specialities> GetSpecialitie(int SPEC_ID);
        Task<Specialities> CreateSpecialitie(Specialities specialitie);
        Task<Specialities> UpdateSpecialitie(Specialities specialitie);
        Task<Specialities> DeleteSpecialitie(int SPEC_ID);

    }
    public class SpecialitiesService : ISpecialitiesService
    {
        private readonly ISpecialitiesRepository _specialitiesRepository;

        public SpecialitiesService(ISpecialitiesRepository specialitiesRepository)
        {
            _specialitiesRepository = specialitiesRepository;
        }

        public async Task<List<Specialities>> GetAll()
        {
            return await _specialitiesRepository.GetAll();
        }

        public async Task<Specialities> GetSpecialitie(int SPEC_ID)
        {
            return await _specialitiesRepository.GetSpecialitie(SPEC_ID);
        }

        public async Task<Specialities> CreateSpecialitie(Specialities specialitie)
        {
            return await _specialitiesRepository.CreateSpecialitie(
                specialitie.SPEC_ID, specialitie.SPECDSC);
        }

        public async Task<Specialities> UpdateSpecialitie(Specialities specialitie)
        {
            return await _specialitiesRepository.UpdateSpecialitie(specialitie);
        }

        public async Task<Specialities> DeleteSpecialitie(int SPEC_ID)
        {
            return await _specialitiesRepository.DeleteSpecialitie(SPEC_ID);
        }
    }
}

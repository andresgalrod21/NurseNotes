using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ISpecialitiesRepository
    {
        Task<List<Specialities>> GetAll();
        Task<Specialities> GetSpecialitie(int SPEC_ID);
        Task<Specialities> CreateSpecialitie(int SPEC_ID, string SPECDSC);
        Task<Specialities> GetSpecialitieBySpecDsc(int SPECDSC);
        Task<Specialities> UpdateSpecialitie(Specialities specialities);
        Task<Specialities> DeleteSpecialitie(int SPEC_ID);

    }
    public class SpecialitiesRepository : ISpecialitiesRepository
    {
        private readonly TestDbNurseNotes _db;
        public SpecialitiesRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Specialities> CreateSpecialitie(int SPEC_ID, string SPECDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Specialities> DeleteSpecialitie(int SPEC_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Specialities>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Specialities> GetSpecialitie(int SPEC_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Specialities> GetSpecialitieBySpecDsc(int SPECDSC)
        {
            throw new NotImplementedException();
        }

        public Task<Specialities> UpdateSpecialitie(Specialities specialities)
        {
            throw new NotImplementedException();
        }
    }
}

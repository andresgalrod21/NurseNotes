using NurseNotes.Context;
using NurseNotes.Model;

namespace Headquarter.repositorio
{
    public interface IHeadquarterRepository
    {
        Task<List<Headquarter>> GetAll();
        Task<Headquarter> GetHeadquarter(int HEADQ_ID);
        Task<Headquarter> CreateHeadquarter(int HEADQ_ID, string HEADQ_DSC);
        Task<Headquarter> UpdateHeadquarter(Headquarter headquarter);
        Task<Headquarter> DeleteHeadquarter(int HEADQ_ID);
    }

}



    public class HeadquarterRepository : IHeadquarterRepository
    {
        private readonly TestDbNurseNotes _db;

        public HeadquarterRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public  Task<Headquarter> CreateHeadquarter(int HEADQ_ID, string HEADQ_DSC)
        {
        throw new NotImplementedException();
    }

        public  Task<Headquarter> UpdateHeadquarter(Headquarter headquarter)
        {
        throw new NotImplementedException();
    }

        public  Task<Headquarter> DeleteHeadquarter(int HEADQ_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<Headquarter> GetHeadquarter(int HEADQ_ID)
        {
        throw new NotImplementedException();
    }

        public  Task<List<Headquarter>> GetAll()
        {
        throw new NotImplementedException();
    }
        }

using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ISignsRepository
    {
        Task<List<Signs>> GetAll();
        Task<Signs> GetSign(int SIGN_ID);
        Task<Signs> CreateSign(int SIGN_ID, int NOTE_ID, int TEMPERATURE, string PULSE);
        Task<Signs> GetSignByNote(int NOTE_ID);
        Task<Signs> UpdateSign(Signs signs);
        Task<Signs> DeleteSign(int SIGN_ID);

    }
    public class SignsRepository : ISignsRepository
    {
        private readonly TestDbNurseNotes _db;
        public SignsRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public Task<Signs> CreateSign(int SIGN_ID, int NOTE_ID, int TEMPERATURE, string PULSE)
        {
            throw new NotImplementedException();
        }

        public Task<Signs> DeleteSign(int SIGN_ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Signs>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Signs> GetSign(int SIGN_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Signs> GetSignByNote(int NOTE_ID)
        {
            throw new NotImplementedException();
        }

        public Task<Signs> UpdateSign(Signs signs)
        {
            throw new NotImplementedException();
        }
    }
}

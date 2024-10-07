using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface ISignsRepository
    {
        Task<List<Signs>> GetAll();
        Task<Signs> GetSign(int SIGN_ID);
        Task<Signs> CreateSign(int SIGN_ID, int NOTE_ID, int TEMPERATURE, string PULSE);
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
        public async Task<List<Signs>> GetAll()
        {
            return await _db.Signs.ToListAsync();
        }

        public async Task<Signs> GetSign(int SIGN_ID)
        {
            return await _db.Signs.FirstOrDefaultAsync(s => s.SIGN_ID == SIGN_ID);
        }

        public async Task<Signs> CreateSign(int SIGN_ID, int NOTE_ID, int TEMPERATURE, string PULSE)
        {
            NurseNote NurseNotes = await _db.NurseNotes.FindAsync(NOTE_ID);
            if (NurseNotes == null)
            {
                throw new Exception("Note not found");
            }

            Signs newSign = new Signs
            {
                SIGN_ID = SIGN_ID,
                NOTE_ID = NOTE_ID,
                TEMPERATURE = TEMPERATURE,
                PULSE = PULSE,
                NurseNote = NurseNotes
            };

            await _db.Signs.AddAsync(newSign);
            await _db.SaveChangesAsync();

            return newSign;
        }

        public async Task<Signs> UpdateSign(Signs signs)
        {
            _db.Signs.Update(signs);
            await _db.SaveChangesAsync();
            return signs;
        }

        public async Task<Signs> DeleteSign(int SIGN_ID)
        {
            Signs signs = await GetSign(SIGN_ID);
            _db.Signs.Remove(signs);
            await _db.SaveChangesAsync();

            return signs;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NurseNotes.Context;
using NurseNotes.Model;

namespace NurseNotes.Repositorio
{
    public interface IScoresRepository
    {
        Task<List<Scores>> GetAll();
        Task<Scores> GetScore(int SCORE_ID);
        Task<Scores> CreateScore(int SCORE_ID, string PLAYERNAME, int AGE, String GENDER, int SCORE);
        Task<Scores> UpdateScore(Scores Scores);
        Task<Scores> DeleteScore(int SCORE_ID);

    }
    public class ScoresRepository : IScoresRepository
    {
        private readonly TestDbNurseNotes _db;

        public ScoresRepository(TestDbNurseNotes db)
        {
            _db = db;
        }

        public async Task<List<Scores>> GetAll()
        {
            return await _db.Scores.ToListAsync();
        }

        public async Task<Scores> GetScore(int SCORE_ID)
        {
            return await _db.Scores.FirstOrDefaultAsync(s => s.SCORE_ID == SCORE_ID);
        }

        public async Task<Scores> CreateScore(int SCORE_ID, string PLAYERNAME, int AGE, string GENDER, int SCORE)
        {
            Scores newScore = new Scores
            {
                SCORE_ID = SCORE_ID,
                PLAYERNAME = PLAYERNAME,
                AGE = AGE,
                GENDER = GENDER,
                SCORE = SCORE
            };

            await _db.Scores.AddAsync(newScore);
            await _db.SaveChangesAsync();

            return newScore;
        }

        public async Task<Scores> UpdateScore(Scores scores)
        {
            _db.Scores.Update(scores);
            await _db.SaveChangesAsync();
            return scores;
        }

        public async Task<Scores> DeleteScore(int SCORE_ID)
        {
            Scores score = await GetScore(SCORE_ID);
            _db.Scores.Remove(score);
            await _db.SaveChangesAsync();

            return score;
        }
    }
}

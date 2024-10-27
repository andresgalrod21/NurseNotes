using NurseNotes.Model;
using NurseNotes.Repositorio;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NurseNotes.Services
{
    public interface IScoresService
    {
        Task<List<Scores>> GetAll();
        Task<Scores> GetScore(int SCORE_ID);
        Task<Scores> CreateScore(Scores Score);
        Task<Scores> UpdateScore(Scores Score);
        Task<Scores> DeleteScore(int SCORE_ID);

    }
    public class ScoresService : IScoresService
    {
        private readonly IScoresRepository _scoresRepository;

        public ScoresService(IScoresRepository scoresRepository)
        {
            _scoresRepository = scoresRepository;
        }

        public async Task<List<Scores>> GetAll()
        {
            return await _scoresRepository.GetAll();
        }

        public async Task<Scores> GetScore(int SCORE_ID)
        {
            return await _scoresRepository.GetScore(SCORE_ID);
        }

        public async Task<Scores> CreateScore(Scores score)
        {
            return await _scoresRepository.CreateScore(
                score.SCORE_ID, score.PLAYERNAME, score.AGE, score.GENDER, score.SCORE);
        }

        public async Task<Scores> UpdateScore(Scores score)
        {
            return await _scoresRepository.UpdateScore(score);
        }

        public async Task<Scores> DeleteScore(int SCORE_ID)
        {
            return await _scoresRepository.DeleteScore(SCORE_ID);
        }
    }
}

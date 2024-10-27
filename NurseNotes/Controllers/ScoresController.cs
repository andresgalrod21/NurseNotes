using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class ScoresController : ControllerBase
    {
        private readonly IScoresService _scoresService;

        public ScoresController(IScoresService scoresService)
        {
            _scoresService = scoresService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Scores>>> GetAll()
        {
            var scores = await _scoresService.GetAll();
            return Ok(scores);
        }

        [HttpGet("{SCORE_ID}")]
        public async Task<ActionResult<Scores>> GetScore(int SCORE_ID)
        {
            var score = await _scoresService.GetScore(SCORE_ID);
            if (score == null)
            {
                return NotFound("Score not found");
            }
            return Ok(score);
        }

        [HttpPost]
        public async Task<ActionResult<Scores>> CreateScore([FromBody] Scores score)
        {
            if (score == null)
            {
                return BadRequest("Score cannot be created");
            }

            var createdScore = await _scoresService.CreateScore(score);
            return CreatedAtAction(nameof(GetScore), new { SCORE_ID = createdScore.SCORE_ID }, createdScore);
        }

        [HttpPut("{SCORE_ID}")]
        public async Task<ActionResult<Scores>> UpdateScore(int SCORE_ID, [FromBody] Scores score)
        {
            if (score == null || score.SCORE_ID != SCORE_ID)
            {
                return BadRequest("Score cannot be updated");
            }

            var updatedScore = await _scoresService.UpdateScore(score);
            if (updatedScore == null)
            {
                return NotFound("Score not found");
            }

            return Ok(updatedScore);
        }

        [HttpDelete("{SCORE_ID}")]
        public async Task<ActionResult> DeleteScore(int SCORE_ID)
        {
            var score = await _scoresService.DeleteScore(SCORE_ID);
            if (score == null)
            {
                return NotFound("Score not found");
            }
            return NoContent();
        }
    }
}

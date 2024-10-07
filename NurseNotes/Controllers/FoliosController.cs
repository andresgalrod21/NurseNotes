using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class FoliosController : ControllerBase
    {
        private readonly IFoliosService _foliosService;

        public FoliosController(IFoliosService foliosService)
        {
            _foliosService = foliosService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Folios>>> GetAll()
        {
            var folios = await _foliosService.GetAll();
            return Ok(folios);
        }

        [HttpGet("{FOLIO_ID}")]
        public async Task<ActionResult<Folios>> GetFolio(int FOLIO_ID)
        {
            var folio = await _foliosService.GetFolio(FOLIO_ID);
            if (folio == null)
            {
                return NotFound("Folio not found");
            }
            return Ok(folio);
        }

        [HttpPost]
        public async Task<ActionResult<Folios>> CreateFolio([FromBody] Folios folio)
        {
            if (folio == null)
            {
                return BadRequest("Folio cannot be created");
            }

            var createdFolio = await _foliosService.CreateFolio(folio);
            return CreatedAtAction(nameof(GetFolio), new { FOLIO_ID = createdFolio.FOLIO_ID }, createdFolio);
        }

        [HttpPut("{FOLIO_ID}")]
        public async Task<ActionResult<Folios>> UpdateFolio(int FOLIO_ID, [FromBody] Folios folio)
        {
            if (folio == null || folio.FOLIO_ID != FOLIO_ID)
            {
                return BadRequest("Folio cannot be updated");
            }

            var updatedFolio = await _foliosService.UpdateFolio(folio);
            if (updatedFolio == null)
            {
                return NotFound("Folio not found");
            }

            return Ok(updatedFolio);
        }

        [HttpDelete("{FOLIO_ID}")]
        public async Task<ActionResult> DeleteFolio(int FOLIO_ID)
        {
            var deletedFolio = await _foliosService.DeleteFolio(FOLIO_ID);
            if (deletedFolio == null)
            {
                return NotFound("Folio not found");
            }
            return NoContent();
        }
    }
}

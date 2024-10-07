using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class TipDocsController : ControllerBase
    {
        private readonly ITipDocsService _tipDocsService;
        public TipDocsController(ITipDocsService tipDocsService)
        {
            _tipDocsService = tipDocsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TipDocs>>> GetAll()
        {
            var tipDocs = await _tipDocsService.GetAll();
            return Ok(tipDocs);
        }

        [HttpGet("{TIPDOC_ID}")]
        public async Task<ActionResult<TipDocs>> GetTipDoc(int TIPDOC_ID)
        {
            var tipDoc = await _tipDocsService.GetTipDoc(TIPDOC_ID);
            if (tipDoc == null)
            {
                return NotFound("TipDoc not found");
            }
            return Ok(tipDoc);
        }

        [HttpPost]
        public async Task<ActionResult<TipDocs>> CreateTipDoc([FromBody] TipDocs tipDoc)
        {
            if (tipDoc == null)
            {
                return BadRequest("TipDoc cannot be created");
            }

            var createdTipDoc = await _tipDocsService.CreateTipDoc(tipDoc);
            return CreatedAtAction(nameof(GetTipDoc), new { TIPDOC_ID = createdTipDoc.TIPDOC_ID }, createdTipDoc);
        }

        [HttpPut("{TIPDOC_ID}")]
        public async Task<ActionResult<TipDocs>> UpdateTipDoc(int TIPDOC_ID, [FromBody] TipDocs tipDoc)
        {
            if (tipDoc == null || tipDoc.TIPDOC_ID != TIPDOC_ID)
            {
                return BadRequest("TipDoc cannot be updated");
            }

            var updatedTipDoc = await _tipDocsService.UpdateTipDoc(tipDoc);
            if (updatedTipDoc == null)
            {
                return NotFound("TipDoc not found");
            }

            return Ok(updatedTipDoc);
        }

        [HttpDelete("{TIPDOC_ID}")]
        public async Task<ActionResult> DeleteTipDoc(int TIPDOC_ID)
        {
            var tipDoc = await _tipDocsService.DeleteTipDoc(TIPDOC_ID);
            if (tipDoc == null)
            {
                return NotFound("TipDoc not found");
            }
            return NoContent();
        }
    }
}

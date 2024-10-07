using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class NurseNoteController : ControllerBase
    {
        private readonly INurseNoteService _nurseNoteService;

        public NurseNoteController(INurseNoteService nurseNoteService)
        {
            _nurseNoteService = nurseNoteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<NurseNote>>> GetAll()
        {
            var notes = await _nurseNoteService.GetAll();
            return Ok(notes);
        }

        [HttpGet("{NOTE_ID}")]
        public async Task<ActionResult<NurseNote>> GetNote(int NOTE_ID)
        {
            var note = await _nurseNoteService.GetNote(NOTE_ID);
            if (note == null)
            {
                return NotFound("Nurse note not found");
            }
            return Ok(note);
        }

        [HttpPost]
        public async Task<ActionResult<NurseNote>> CreateNote([FromBody] NurseNote note)
        {
            if (note == null)
            {
                return BadRequest("Nurse note cannot be created");
            }

            var createdNote = await _nurseNoteService.CreateNote(note);
            return CreatedAtAction(nameof(GetNote), new { NOTE_ID = createdNote.NOTE_ID }, createdNote);
        }

        [HttpPut("{NOTE_ID}")]
        public async Task<ActionResult<NurseNote>> UpdateNote(int NOTE_ID, [FromBody] NurseNote note)
        {
            if (note == null || note.NOTE_ID != NOTE_ID)
            {
                return BadRequest("Nurse note cannot be updated");
            }

            var updatedNote = await _nurseNoteService.UpdateNote(note);
            if (updatedNote == null)
            {
                return NotFound("Nurse note not found");
            }

            return Ok(updatedNote);
        }

        [HttpDelete("{NOTE_ID}")]
        public async Task<ActionResult> DeleteNote(int NOTE_ID)
        {
            var deletedNote = await _nurseNoteService.DeleteNote(NOTE_ID);
            if (deletedNote == null)
            {
                return NotFound("Nurse note not found");
            }
            return NoContent();
        }
    }
}

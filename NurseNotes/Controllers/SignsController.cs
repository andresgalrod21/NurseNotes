using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class SignsController : ControllerBase
    {
        private readonly ISignsService _signService;

        public SignsController(ISignsService signsService)
        {
            _signService = signsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Signs>>> GetAll()
        {
            var signs = await _signService.GetAll();
            return Ok(signs);
        }

        [HttpGet("{SIGN_ID}")]
        public async Task<ActionResult<Signs>> GetSign(int SIGN_ID)
        {
            var sign = await _signService.GetSign(SIGN_ID);
            if (sign == null)
            {
                return NotFound("Sign not found");
            }
            return Ok(sign);
        }

        [HttpPost]
        public async Task<ActionResult<Signs>> CreateSign([FromBody] Signs sign)
        {
            if (sign == null)
            {
                return BadRequest("Sign cannot be created");
            }

            var createdSign = await _signService.CreateSign(sign);
            return CreatedAtAction(nameof(GetSign), new { SIGN_ID = createdSign.SIGN_ID }, createdSign);
        }

        [HttpPut("{SIGN_ID}")]
        public async Task<ActionResult<Signs>> UpdateSign(int SIGN_ID, [FromBody] Signs sign)
        {
            if (sign == null || sign.SIGN_ID != SIGN_ID)
            {
                return BadRequest("Sign cannot be updated");
            }

            var updatedSign = await _signService.UpdateSign(sign);
            if (updatedSign == null)
            {
                return NotFound("Sign not found");
            }

            return Ok(updatedSign);
        }

        [HttpDelete("{SIGN_ID}")]
        public async Task<ActionResult> DeleteSign(int SIGN_ID)
        {
            var sign = await _signService.DeleteSign(SIGN_ID);
            if (sign == null)
            {
                return NotFound("Sign not found");
            }
            return NoContent();
        }
    }
}

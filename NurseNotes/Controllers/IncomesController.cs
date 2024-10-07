using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NurseNotes.Model;
using NurseNotes.Services;

namespace NurseNotes.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class IncomesController : ControllerBase
    {
        private readonly IIncomesService _incomesService;

        public IncomesController(IIncomesService incomesService)
        {
            _incomesService = incomesService;            
        }

        [HttpGet]
        public async Task<ActionResult<List<Incomes>>> GetAll()
        {
            var incomes = await _incomesService.GetAll();
            return Ok(incomes);
        }

        [HttpGet("{INCOME_ID}")]
        public async Task<ActionResult<Incomes>> GetIncome(int INCOME_ID)
        {
            var income = await _incomesService.GetIncome(INCOME_ID);
            if (income == null)
            {
                return NotFound("Income not found");
            }
            return Ok(income);
        }

        [HttpPost]
        public async Task<ActionResult<Incomes>> CreateIncome([FromBody] Incomes income)
        {
            if (income == null)
            {
                return BadRequest("Income cannot be created");
            }

            var createdIncome = await _incomesService.CreateIncome(income);
            return CreatedAtAction(nameof(GetIncome), new { INCOME_ID = createdIncome.INCOME_ID }, createdIncome);
        }

        [HttpPut("{INCOME_ID}")]
        public async Task<ActionResult<Incomes>> UpdateIncome(int INCOME_ID, [FromBody] Incomes income)
        {
            if (income == null || income.INCOME_ID != INCOME_ID)
            {
                return BadRequest("Income cannot be updated");
            }

            var updatedIncome = await _incomesService.UpdateIncome(income);
            if (updatedIncome == null)
            {
                return NotFound("Income not found");
            }

            return Ok(updatedIncome);
        }

        [HttpDelete("{INCOME_ID}")]
        public async Task<ActionResult> DeleteIncome(int INCOME_ID)
        {
            var deletedIncome = await _incomesService.DeleteIncome(INCOME_ID);
            if (deletedIncome == null)
            {
                return NotFound("Income not found");
            }
            return NoContent();
        }
    }
}

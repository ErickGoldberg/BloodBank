using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace BloodBank.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            if (id == 0)
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] string value)
        {

            return Created();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] string value)
        {
            if (id == 0)
                return NotFound();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
                return NotFound();

            return Ok();
        }
    }
}
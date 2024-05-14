using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] string value)
        {


            return Created();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] string value)
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

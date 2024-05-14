using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BloodStockController : ControllerBase
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

        [HttpGet("{bloodType}")]
        public async Task<ActionResult> bloodType(string bloodType)
        {
            

            return Ok();
        }
    }
}

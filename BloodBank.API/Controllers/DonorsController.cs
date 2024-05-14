using Microsoft.AspNetCore.Mvc;

namespace BloodBank.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DonorsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> Register(int id)
        {

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Update(int id)
        {

            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {

            return Ok();
        }
    }
}

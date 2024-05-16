using BloodBank.Application.DTOs;
using BloodBank.Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace BloodBank.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly ICepRepository _cepRepository;

        public AddressesController(ICepRepository cepRepository)
        {
            _cepRepository = cepRepository;
        }

        [HttpGet("{cep}")]
        public async Task<ActionResult<CepDto>> Get(string cep)
        {
            CepDto? address;

            try
            {
                address = await _cepRepository.GetAddressByCepAsync(cep);

                if (address?.PostalCode is null)
                    return BadRequest("CEP does not exist");
            }
            catch
            {
                return BadRequest("CEP is in invalid format");
            }
            
            return Ok(address);
        }
    }
}

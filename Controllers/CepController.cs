using elshaday_test_api.Integration.Interfaces;
using elshaday_test_api.Integration.Response;
using Microsoft.AspNetCore.Mvc;

namespace elshaday_test_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegration _viaCepIntegration;
        public CepController(IViaCepIntegration viaCepIntegration)
        {
            _viaCepIntegration = viaCepIntegration;
        }

        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> GetAddress(string cep)
        {
            var responseData = await _viaCepIntegration.getViaCepData(cep);

            if (responseData == null)
            {
                return NotFound("Cep não encontrado");
            }

            return Ok(responseData);
        }
    }
}

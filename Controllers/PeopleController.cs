using elshaday_test_api.Data.Repository;
using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepository personRepository;
        public PeopleController(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> IndexAsync()
        {
            return await personRepository.GetAllAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Person>> CreateAsync([FromBody] NewPerson person)
        {
            try
            {
                await personRepository.Create(person);
                return Ok(person);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

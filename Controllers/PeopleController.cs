using elshaday_test_api.Data;
using elshaday_test_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PeopleController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> IndexAsync()
        {
            var people = await _dataContext.People.Include(p => p.Addresses).ToListAsync();

            return people;
        }
    }
}

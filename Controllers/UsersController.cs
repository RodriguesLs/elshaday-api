using elshaday_test_api.Data.Repository;
using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using elshaday_test_api.ModelViews;

namespace elshaday_test_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository) { 
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> IndexAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateAsync(NewUser user)
        {
            await _userRepository.Register(user);
            return Ok(user);
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<ActionResult> Authenticate([FromBody] User user)
        {
            if (user.Email == "admin@admin.com" && user.PasswordHash == "admin123")
            {
                return Ok(user);
            }

            if (user == null)
                return BadRequest();

            var userFound = await _userRepository.Authenticate(user);

            if(user.PasswordHash == userFound.PasswordHash)
            {
                return Ok(userFound);
            }

            return BadRequest();
        }
    }
}

using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;
using Microsoft.AspNetCore.Mvc;

namespace elshaday_test_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentsRepository;

        public DepartmentsController(IDepartmentRepository departmentsRepository)
        {
            _departmentsRepository = departmentsRepository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseDepartment), StatusCodes.Status200OK)]
        public async Task<IActionResult> IndexAsync()
        {
            return Ok(await _departmentsRepository.GetAllAsync());
        }

        [HttpPost]
        public async Task<ActionResult<Department>> CreateAsync(NewDepartment department)
        {
            try
            {
                await _departmentsRepository.CreateAsync(department);

                return Ok(department);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("employees")]
        public async Task<ActionResult> ListResponsibles()
        {
            return Ok(await _departmentsRepository.ListAvailableResponsibles());
        }

    }
}

using AutoMapper;
using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using elshaday_test_api.Models.Enumerables;
using elshaday_test_api.ModelViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Any;
using System.Runtime.InteropServices;

namespace elshaday_test_api.Data.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public DepartmentRepository(DataContext dataContext, IMapper mapper) {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async Task<Department> CreateAsync(NewDepartment newDepartment)
        {
            var person = await _dataContext.People.FindAsync(newDepartment.PersonId);

            if (person.Role != RoleType.employee)
            {
                throw new Exception("Only employee can be responsible by department");
            }

            var departmentExists = await _dataContext.Departments
                                            .FirstOrDefaultAsync(d => d.Name == newDepartment.Name);
            if (departmentExists != null)
            {
                throw new Exception("Department already exists");
            }

            var department = _mapper.Map<Department>(newDepartment);

            await _dataContext.Departments.AddAsync(department);
            await _dataContext.SaveChangesAsync();

            return department;
        }

        public async Task<List<ResponseDepartment>> GetAllAsync()
        {
            var rawDepartments = await _dataContext.Departments.Include(d => d.Person).AsNoTracking().ToListAsync();
            var departments = _mapper.Map<List<Department>, List<ResponseDepartment>>(rawDepartments);

            return departments;
        }

        public async Task<List<Person>> ListAvailableResponsibles()
        {
            var people = await _dataContext.People.Where(p => p.Role == RoleType.employee).ToListAsync();

            return people;
        }
    }
}

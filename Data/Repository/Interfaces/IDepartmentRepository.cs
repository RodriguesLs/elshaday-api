using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;

namespace elshaday_test_api.Data.Repository.Interfaces
{
    public interface IDepartmentRepository
    {
        public Task<List<ResponseDepartment>> GetAllAsync();
        public Task<Department> CreateAsync(NewDepartment department);
        public Task<List<Person>> ListAvailableResponsibles();
    }
}

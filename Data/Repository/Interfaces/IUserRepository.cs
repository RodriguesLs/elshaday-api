using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllAsync();
        public Task<User> Register(NewUser user);
        public Task<User> Authenticate(User user);
        
    }
}

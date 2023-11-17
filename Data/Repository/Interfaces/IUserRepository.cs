using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Data.Repository.Interfaces
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllAsync();
        public Task<User> Register(User user);
        public Task<User> Authenticate(User user);
        
    }
}

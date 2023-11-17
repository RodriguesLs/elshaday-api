using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;

        public UserRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> Register(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> Authenticate(User user)
        {
            var userFound = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            return userFound;
        }
    }
}

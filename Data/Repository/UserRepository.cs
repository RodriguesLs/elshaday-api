using AutoMapper;
using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dbContext;
        private readonly IMapper _mapper;

        public UserRepository(DataContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> Register(NewUser newUser)
        {
            var user = _mapper.Map<User>(newUser);

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

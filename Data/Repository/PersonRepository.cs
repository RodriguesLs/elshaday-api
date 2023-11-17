using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _dbContext;

        public PersonRepository(DataContext dbContext) { 
            _dbContext = dbContext;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _dbContext.People.Include(p => p.Addresses).AsNoTracking().ToListAsync();
        }

        public async Task<Person?> GetAsync(int id)
        {
            return await _dbContext.People.FindAsync(id);
        }

        public async Task<Person> Create(Person person)
        {
            var emailExists = await _dbContext.People.AnyAsync(p => p.Document == person.Document);

            if (emailExists != null)
            {
                throw new Exception("Email already exists");
            }

            await _dbContext.People.AddAsync(person);
            await _dbContext.SaveChangesAsync();

            return person;
        }

        public Task<Person> Update(Person person, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Person> Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}

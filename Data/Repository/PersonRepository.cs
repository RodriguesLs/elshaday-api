using AutoMapper;
using elshaday_test_api.Data.Repository.Interfaces;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;
using Microsoft.EntityFrameworkCore;

namespace elshaday_test_api.Data.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _dbContext;
        private readonly IMapper _mapper;

        public PersonRepository(DataContext dbContext, IMapper mapper) { 
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _dbContext.People.Include(p => p.Addresses).AsNoTracking().ToListAsync();
        }

        public async Task<Person?> GetAsync(int id)
        {
            return await _dbContext.People.FindAsync(id);
        }

        public async Task<Person> Create(NewPerson newPerson)
        {
            var documentExists = await _dbContext.People.AnyAsync(p => p.Document == newPerson.Document);

            if (documentExists)
            {
                throw new Exception("Document already exists");
            }

            var person = _mapper.Map<Person>(newPerson);

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

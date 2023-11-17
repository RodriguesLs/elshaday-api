using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;

namespace elshaday_test_api.Data.Repository.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> GetAsync(int id);
        Task<Person> Create(NewPerson person);
        Task<Person> Update(Person person, int id);
        Task<Person> Delete(int id);
    }
}

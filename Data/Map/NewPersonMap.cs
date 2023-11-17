using AutoMapper;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;

namespace elshaday_test_api.Data.Map
{
    public class NewPersonMap : Profile
    {
        public NewPersonMap() {
            CreateMap<NewPerson, Person>()
                .ForMember(p => p.CreatedAt, opt => opt.MapFrom(o => DateTime.Now));

            CreateMap<NewAddress, Address>();
        }
    }
}

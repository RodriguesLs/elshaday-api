using AutoMapper;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;

namespace elshaday_test_api.Data.Map
{
    public class NewDepartmentMap : Profile
    {
        public NewDepartmentMap() {
            CreateMap<NewDepartment, Department>()
                .ForMember(d => d.CreatedAt, opt => opt.MapFrom(o => DateTime.Now));
            CreateMap<Department, ResponseDepartment>()
                .ForMember(x => x.PersonName, opt => opt.MapFrom(src => src.Person.Name));
        }
    }
}

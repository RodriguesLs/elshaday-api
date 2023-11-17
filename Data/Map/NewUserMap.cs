using AutoMapper;
using elshaday_test_api.Models;
using elshaday_test_api.ModelViews;

namespace elshaday_test_api.Data.Map
{
    public class NewUserMap : Profile
    {
        public NewUserMap()
        {
            CreateMap<NewUser, User>()
                .ForMember(u => u.CreatedAt, opt => opt.MapFrom(o => DateTime.Now));
        }
    }
}

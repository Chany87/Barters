using DAL.Models;
using System;

namespace DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<CategoryDTO, Category>();
            CreateMap<Category,CategoryDTO>();
            CreateMap<User, UserDTO>();
            CreateMap< UserDTO, User>();
            CreateMap<Massage, MassageDTO>();
            CreateMap<MassageDTO, Massage>();
        }
    }
}

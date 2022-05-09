using AutoMapper;
using Net.Experience.Application.UseCases.User.Register;
using Net.Experience.Application.UseCases.User.UpdateUser;
using Net.Experience.Domain.Dtos;

namespace Net.Experience.Application.AutoMapper
{
    public class AutoMappingUser : Profile
    {
        public AutoMappingUser()
        {
            CreateMap<RegisterUserRequest, UserDto>();
            CreateMap<UpdateUserRequest, UserDto>();
        }
    }
}

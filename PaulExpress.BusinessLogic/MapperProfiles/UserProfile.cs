using AutoMapper;
using PaulExpress.Domain.Dtos.Simple;
using PaulExpress.Domain.Entities;

namespace PaulExpress.BusinessLogic.MapperProfiles
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>();

            CreateMap<UserRole, UserRoleDto>();
        }
    }
}
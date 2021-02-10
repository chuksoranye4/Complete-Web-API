using AutoMapper;
using CompleteWebApi.Data.Models;

namespace CompleteWebApi.Data.AutoMapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<UserInfo, UserInfoCreateUpdateDto>();
            CreateMap<UserInfoCreateUpdateDto, UserInfo>();

            CreateMap<UserInfo, UserInfoReadDto>();
        }
    }
}

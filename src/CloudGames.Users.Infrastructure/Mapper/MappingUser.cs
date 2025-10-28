using AutoMapper;
using CloudGames.Users.Domain.Entities;
using CloudGames.Users.Domain.Requests;
using CloudGames.Users.Domain.Responses;

namespace CloudGames.Users.Infrastructure.Mapper;

public class MappingUser : Profile
{
    public MappingUser()
    {
        CreateMap<CreateUserRequest, User>().ReverseMap();
        CreateMap<UpdateUserRequest, User>().ReverseMap();
        CreateMap<UserResponse, User>().ReverseMap();
        CreateMap<IEnumerable<UserResponse>, User>().ReverseMap();
    }
}
using AutoMapper;
using dotNet_FrontMVC.Models;
using dotNet_FrontMVC.Models.Dto;

namespace dotNet_FrontMVC.Mapper;

public class MappingConfig : Profile
{
    public MappingConfig()
    {
        CreateMap<UserCreateDto, UserDto>().ReverseMap();
        CreateMap<UserUpdateDto, UserDto>().ReverseMap();
        CreateMap<UserNumberUpdateDto, UserNumberDto>().ReverseMap();
        CreateMap<UserNumberCreateDto, UserNumberDto>().ReverseMap();
    }
}
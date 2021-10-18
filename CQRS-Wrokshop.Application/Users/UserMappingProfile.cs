using AutoMapper;
using CQRS_Wrokshop.Application.Users.Commands.CreateUser;
using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application.Users
{
   public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CreateUserCommand, User>().ReverseMap();
        }
    }
}

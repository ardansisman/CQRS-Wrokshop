using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application.Users.Queries.GetUserById
{
    public class GetUserByIdQuery:IRequest<ResponseState<UserDto>>
    {
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}

using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application.Users.Queries.GetUsers
{
   public class GetUsersQuery:IRequest<ResponseState<List<UserDto>>>
    {
    }
}

using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Application.Users.Queries.GetUsers
{
   public class GetUsersQueryHandler:IRequestHandler<GetUsersQuery,ResponseState<List<UserDto>>>
    {
        private readonly IUserService _userService;
        public GetUsersQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseState<List<UserDto>>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return  new ResponseState<List<UserDto>>() { Content = await _userService.GetAllAsync() };
        }
    }
}

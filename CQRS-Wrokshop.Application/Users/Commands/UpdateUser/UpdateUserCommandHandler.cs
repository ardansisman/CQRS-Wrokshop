using CQRS_Wrokshop.ResponseStates.Enums;
using CQRS_Wrokshop.ResponseStates.Exceptions;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResponseState>
    {
        private readonly IUserService _userService;
        public UpdateUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseState> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if (!await _userService.UpdateAsync(request))
            {
                throw new StateException { StateCode = StateCode.UnexpectedError }; //TO DO: 
            }

            return new ResponseState(StateCode.UserUpdate);
        }
    }
}

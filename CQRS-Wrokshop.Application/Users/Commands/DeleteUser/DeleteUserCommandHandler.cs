using CQRS_Wrokshop.ResponseStates.Enums;
using CQRS_Wrokshop.ResponseStates.Exceptions;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, ResponseState>
    {
        private readonly IUserService _userService;

        public DeleteUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }
        public async Task<ResponseState> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            if (!await _userService.DeleteAsync(request))
            {
                throw new StateException { StateCode = StateCode.UnexpectedError }; //Error
            }

            return new ResponseState(StateCode.UserDeleted);
        }
    }
}

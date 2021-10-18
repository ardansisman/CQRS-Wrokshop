using CQRS_Wrokshop.ResponseStates.Enums;
using CQRS_Wrokshop.ResponseStates.Exceptions;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Application.Users.Commands.UpdateUserEmail
{
    public class UpdateUserEmailCommandHandler : IRequestHandler<UpdateUserEmailCommand, ResponseState>
    {
        private readonly IUserService _userService;
        public UpdateUserEmailCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<ResponseState> Handle(UpdateUserEmailCommand request, CancellationToken cancellationToken)
        {
            if (!await _userService.UpdateUserEmailAsync(request))
            {
                throw new StateException { StateCode = StateCode.UnexpectedError }; //TO DO: 
            }
            return new ResponseState(StateCode.UserEmailUpdate);
        }
    }
}

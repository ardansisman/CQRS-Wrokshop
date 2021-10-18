using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest<ResponseState>
    {
        public UpdateUserCommand(long id, UpdateUserDto user)
        {
            Id = id;
            User = user;
        }
        public long Id { get; }
        public UpdateUserDto User { get; }
    }
}

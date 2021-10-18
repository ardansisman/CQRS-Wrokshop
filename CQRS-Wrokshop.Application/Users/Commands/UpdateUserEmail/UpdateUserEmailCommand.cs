using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application.Users.Commands.UpdateUserEmail
{
    public class UpdateUserEmailCommand : IRequest<ResponseState>
    {
        public UpdateUserEmailCommand(long id, UpdateUserEmailDto userEmail)
        {
            Id = id;
            UserEmail = userEmail;
        }
        public long Id { get; }
        public UpdateUserEmailDto UserEmail { get; }
    }
}

using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRS_Wrokshop.Application.Users.Commands.DeleteUser
{
   public class DeleteUserCommand:IRequest<ResponseState>
    {
        public DeleteUserCommand(long id)
        {
            Id = id;
        }
        public long Id { get; set; }
    }
}

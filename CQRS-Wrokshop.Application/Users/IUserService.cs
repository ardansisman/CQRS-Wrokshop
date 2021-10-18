using CQRS_Wrokshop.Application.Users.Commands.CreateUser;
using CQRS_Wrokshop.Application.Users.Commands.DeleteUser;
using CQRS_Wrokshop.Application.Users.Commands.UpdateUser;
using CQRS_Wrokshop.Application.Users.Commands.UpdateUserEmail;
using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.ResponseStates.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Application.Users
{
    public interface IUserService
    {
        Task<UserDto> CreateAsync(CreateUserCommand request);
        Task<ResponseState<UserDto>> GetByIdAsync(int id);
        Task<List<UserDto>> GetAllAsync();
        Task<bool> DeleteAsync(DeleteUserCommand request);
        Task<bool> UpdateAsync(UpdateUserCommand request);
        Task<bool> UpdateUserEmailAsync(UpdateUserEmailCommand request);
    }
}

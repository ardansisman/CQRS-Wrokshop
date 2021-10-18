﻿using CQRS_Wrokshop.Application.Users.Commands.CreateUser;
using CQRS_Wrokshop.Application.Users.Commands.DeleteUser;
using CQRS_Wrokshop.Application.Users.Commands.UpdateUser;
using CQRS_Wrokshop.Application.Users.Commands.UpdateUserEmail;
using CQRS_Wrokshop.Application.Users.Dto;
using CQRS_Wrokshop.Application.Users.Queries.GetUserById;
using CQRS_Wrokshop.Application.Users.Queries.GetUsers;
using CQRS_Wrokshop.ResponseStates.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Wrokshop.Api.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/users")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserDto), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> AddAsync([FromBody] CreateUserCommand command)
        {
            if (command == null)
            {
                return BadRequest();
            }
            var user = await _mediator.Send(command);

            return Ok(user);
            //return CreatedAtAction("GetAsync", new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResponseState<UserDto>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ResponseState<UserDto>> GetAsync([FromRoute] int id)
        {
            return await _mediator.Send(new GetUserByIdQuery(id));
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseState<List<UserDto>>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<ResponseState<List<UserDto>>> GetAllAsync()
        {
            return await _mediator.Send(new GetUsersQuery());
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ResponseState), 204)]
        [ProducesResponseType(typeof(ResponseState), 404)]
        [ProducesResponseType(500)]
        public async Task<ResponseState> DeleteAsync(long id)
        {
            return await _mediator.Send(new DeleteUserCommand(id));
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ResponseState), 204)]
        [ProducesResponseType(typeof(ResponseState), 400)]
        [ProducesResponseType(500)]
        public async Task<ResponseState> UpdateAsync(long id, [FromBody] UpdateUserDto command)
        {
            return await _mediator.Send(new UpdateUserCommand(id, command));
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(ResponseState), 204)]
        [ProducesResponseType(typeof(ResponseState), 400)]
        [ProducesResponseType(500)]
        public async Task<ResponseState> UpdateEmailAsync(long id, [FromBody] UpdateUserEmailDto command)
        {
            return await _mediator.Send(new UpdateUserEmailCommand(id, command));
        }
    }
}

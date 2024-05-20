using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Mediatr.Commands.User.Create;
using ECommerce.Core.Application.Mediatr.Commands.User.Delete;
using ECommerce.Core.Application.Mediatr.Commands.User.Update;
using ECommerce.Core.Application.Mediatr.Queries.User.GetAll;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommandRequest createUser)
        {
            CreateUserCommandResponse response = await _mediator.Send(createUser);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            GetAllUserQueryResponse response = await _mediator.Send(new GetAllUserQueryRequest());
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateUserCommandRequest updateUser)
        {
            UpdateUserCommandResponse response = await _mediator.Send(updateUser);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteUserCommandRequest deleteUser)
        {
            DeleteUserCommandResponse response = await _mediator.Send(deleteUser);
            return Ok(response);
        }
    }
}

using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Mediatr.Commands.User.Create;
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
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(UpdateUser updateUser)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}

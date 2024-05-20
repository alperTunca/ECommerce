using ECommerce.Core.Application.DTOs.User;
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
        public async Task<IActionResult> Create(CreateUser createUser)
        {
            CreateUser user = _mediator.Send(createUser);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _mediator.Send<>();
            return Ok(list);
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

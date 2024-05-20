using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderCommentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderCommentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderComment createOrderComment)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOrderComment updateOrderComment)
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

using ECommerce.Core.Application.Mediatr.Commands.OrderComment.Create;
using ECommerce.Core.Application.Mediatr.Commands.OrderComment.Delete;
using ECommerce.Core.Application.Mediatr.Commands.OrderComment.Update;
using ECommerce.Core.Application.Mediatr.Queries.OrderComment.GetAll;
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
        public async Task<IActionResult> Create(CreateOrderCommentCommandRequest createOrderComment)
        {
            CreateOrderCommentCommandResponse response = await _mediator.Send(createOrderComment);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            GetAllOrderCommentQueryResponse response = await _mediator.Send(new GetAllOrderCommentQueryRequest());
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOrderCommentCommandRequest updateOrderComment)
        {
            UpdateOrderCommentCommandResponse response = await _mediator.Send(updateOrderComment);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteOrderCommentCommandRequest deleteOrder)
        {
            DeleteOrderCommentCommandResponse response = await _mediator.Send(deleteOrder);
            return Ok(response);
        }
    }
}

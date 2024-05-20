using ECommerce.Core.Application.Mediatr.Commands.Order.Create;
using ECommerce.Core.Application.Mediatr.Commands.Order.Delete;
using ECommerce.Core.Application.Mediatr.Commands.Order.Update;
using ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus;
using ECommerce.Core.Application.Mediatr.Queries.Order.GetAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderCommandRequest createOrder)
        {
            CreateOrderCommandResponse response = await _mediator.Send(createOrder);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            GetAllOrderQueryResponse response = await _mediator.Send(new GetAllOrderQueryRequest());
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOrderCommandRequest updateOrder)
        {
            UpdateOrderCommandResponse response = await _mediator.Send(updateOrder);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteOrderCommandRequest deleteOrder)
        {
            DeleteOrderCommandResponse response = await _mediator.Send(deleteOrder);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateStatus(UpdateStatusOrderCommandRequest updateStatusOrder)
        {
            UpdateStatusOrderCommandResponse response = await _mediator.Send(updateStatusOrder);
            return Ok(response);
        }
    }
}

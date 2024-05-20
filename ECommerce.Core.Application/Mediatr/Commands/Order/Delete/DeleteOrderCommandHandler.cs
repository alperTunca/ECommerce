using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Delete
{
	public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
	{
		private readonly IOrderService _orderService;

		public DeleteOrderCommandHandler(IOrderService orderService)
		{
			_orderService = orderService;
		}

        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
			await _orderService.DeleteAsync(request.Id);
			return new() { IsSuccess = true };
        }
    }
}


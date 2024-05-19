using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus
{
	public class UpdateStatusOrderCommandHandler : IRequestHandler<UpdateStatusOrderCommandRequest, UpdateStatusOrderCommandResponse>
	{
		private readonly IOrderService _orderService;

		public UpdateStatusOrderCommandHandler(IOrderService orderService)
		{
			_orderService = orderService;
		}

        public async Task<UpdateStatusOrderCommandResponse> Handle(UpdateStatusOrderCommandRequest request, CancellationToken cancellationToken)
        {
			// TODO - Fill
			var result = await _orderService.UpdateStatusAsync(request.);
			return new() { IsSuccess = result };
        }
    }
}


using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Create
{
	public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
	{
        private readonly IOrderService _orderService;

		public CreateOrderCommandHandler(IOrderService orderService)
		{
            _orderService = orderService;
		}

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            // TODO - Fix mapping problem
            var result = await _orderService.CreateAsync(request);
            return new() { IsSuccess = result };
        }
    }
}


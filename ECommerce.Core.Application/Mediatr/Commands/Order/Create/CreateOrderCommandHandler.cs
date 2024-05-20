using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Create
{
	public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
	{
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

		public CreateOrderCommandHandler(IOrderService orderService, IMapper mapper)
		{
            _orderService = orderService;
            _mapper = mapper;
		}

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<CreateOrder>(request);
            await _orderService.CreateAsync(mappedData);
            return new() { IsSuccess = true };
        }
    }
}


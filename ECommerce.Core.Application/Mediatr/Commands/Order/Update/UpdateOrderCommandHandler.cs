using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Update
{
	public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
	{
		private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<UpdateOrder>(request);
			await _orderService.UpdateAsync(mappedData);
			return new() { IsSuccess = true };
        }
    }
}


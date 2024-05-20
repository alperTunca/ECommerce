using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus
{
	public class UpdateStatusOrderCommandHandler : IRequestHandler<UpdateStatusOrderCommandRequest, UpdateStatusOrderCommandResponse>
	{
		private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public UpdateStatusOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<UpdateStatusOrderCommandResponse> Handle(UpdateStatusOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<UpdateStatusOrder>(request);
			await _orderService.UpdateStatusAsync(mappedData);
			return new() { IsSuccess = true };
        }
    }
}


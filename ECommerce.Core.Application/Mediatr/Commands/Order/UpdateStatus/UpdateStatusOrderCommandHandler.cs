using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.UpdateStatus
{
	public class UpdateStatusOrderCommandHandler : IRequestHandler<UpdateStatusOrderCommandRequest, UpdateStatusOrderCommandResponse>
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IMapper _mapper;

        public UpdateStatusOrderCommandHandler(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IMapper mapper)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateStatusOrderCommandResponse> Handle(UpdateStatusOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var data = await _orderReadRepository.GetWhere(x => x.AccountId == request.AccountId && x.OrderNumber == request.OrderNumber).FirstOrDefaultAsync();
            data.Id = request.Id;
            data.AccountId = request.AccountId;
            data.OrderNumber = request.OrderNumber;
            data.Status = request.Status;

            _orderWriteRepository.Update(data);
            await _orderWriteRepository.SaveAsync();
            result = true;
            return new() { IsSuccess = result };
        }
    }
}


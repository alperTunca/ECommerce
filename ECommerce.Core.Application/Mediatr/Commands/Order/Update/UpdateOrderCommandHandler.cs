﻿using System;
using AutoMapper;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Update
{
	public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
	{
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IMapper mapper)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            try
            {
                var data = await _orderReadRepository.GetWhere(x => x.AccountId == request.AccountId && x.OrderNumber == request.OrderNumber).FirstOrDefaultAsync();
                data.UserId = request.UserId;
                data.AccountId = request.AccountId;
                data.OrderNumber = request.OrderNumber;
                data.OrderDate = request.OrderDate;
                data.OrderType = request.OrderType;
                data.Status = request.Status;
                data.SalesChannel = request.SalesChannel;
                data.City = request.City;
                data.District = request.District;
                data.Carrier = request.Carrier;

                _orderWriteRepository.Update(data);
                await _orderWriteRepository.SaveAsync();
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return new() { IsSuccess = true };
        }
    }
}


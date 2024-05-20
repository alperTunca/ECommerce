using System;
using System.Transactions;
using AutoMapper;

using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Create
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderWriteRepository orderWriteRepository, IMapper mapper)
        {
            _orderWriteRepository = orderWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            try
            {
                await _orderWriteRepository.AddAsync(new()
                {
                    UserId = request.UserId,
                    AccountId = request.AccountId,
                    OrderNumber = request.OrderNumber,
                    OrderDate = request.OrderDate,
                    OrderType = request.OrderType,
                    Status = request.Status,
                    SalesChannel = request.SalesChannel,
                    City = request.City,
                    District = request.District,
                    Carrier = request.Carrier
                });
                await _orderWriteRepository.SaveAsync();

                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return new() { IsSuccess = result };
        }
    }
}


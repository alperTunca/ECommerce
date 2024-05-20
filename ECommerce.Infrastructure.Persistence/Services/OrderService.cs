using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using ECommerce.Core.Domain.Entities;

namespace ECommerce.Infrastructure.Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, IMapper mapper)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _mapper = mapper;
        }

        public Task<bool> CreateAsync(CreateOrder createOrder)
        {
            var mappedData = _mapper.Map<Order>(createOrder);
            var result = await _orderWriteRepository.AddAsync(mappedData);
            return result;
        }

        public ListOrder GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<SingleOrder> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UpdateOrder updateOrder)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStatusAsync(UpdateStatusOrder updateOrderStatus)
        {
            throw new NotImplementedException();
        }
    }
}


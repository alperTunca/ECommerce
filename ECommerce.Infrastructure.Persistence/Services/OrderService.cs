using System;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Repositories.OrderRepositories;

namespace ECommerce.Infrastructure.Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;

        public OrderService(IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }

        public Task<bool> CreateAsync(CreateOrder createOrder)
        {
            throw new NotImplementedException();
        }

        public Task<ListOrder> GetAllAsync()
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


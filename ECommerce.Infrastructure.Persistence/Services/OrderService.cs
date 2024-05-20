using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using ECommerce.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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

        public async Task CreateAsync(CreateOrder createOrder)
        {
            var mappedData = _mapper.Map<Order>(createOrder);
            await _orderWriteRepository.AddAsync(mappedData);
            await _orderWriteRepository.SaveAsync();
        }

        public ListOrder GetAll()
        {
            var result = _orderReadRepository.GetAll().ToList();
            var mappedData = _mapper.Map<ListOrder>(result);
            return mappedData;
        }

        public async Task<SingleOrder> GetByIdAsync(int id)
        {
            var result = await _orderReadRepository.GetByIdAsync(id);
            var mappedData = _mapper.Map<SingleOrder>(result);
            return mappedData;
        }

        public async Task UpdateAsync(UpdateOrder updateOrder)
        {
            var data = await _orderReadRepository.GetByIdAsync(updateOrder.Id);
            data.UserId = updateOrder.UserId;
            data.AccountId = updateOrder.AccountId;
            data.OrderNumber = updateOrder.OrderNumber;
            data.OrderDate = updateOrder.OrderDate;
            data.OrderType = updateOrder.OrderType;
            data.Status = updateOrder.Status;
            data.SalesChannel = updateOrder.SalesChannel;
            data.City = updateOrder.City;
            data.District = updateOrder.District;
            data.Carrier = updateOrder.Carrier;

            _orderWriteRepository.Update(data);
            await _orderWriteRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _orderWriteRepository.Remove(id);
            await _orderWriteRepository.SaveAsync();
        }

        public async Task UpdateStatusAsync(UpdateStatusOrder updateOrderStatus)
        {
            var data = await _orderReadRepository.GetWhere(x => x.AccountId == updateOrderStatus.AccountId && x.OrderNumber == updateOrderStatus.OrderNumber).FirstOrDefaultAsync();
            data.AccountId = updateOrderStatus.AccountId;
            data.OrderNumber = updateOrderStatus.OrderNumber;

            _orderWriteRepository.Update(data);
            await _orderWriteRepository.SaveAsync();
        }
    }
}


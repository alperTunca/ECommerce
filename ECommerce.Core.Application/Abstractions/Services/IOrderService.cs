using System;
using ECommerce.Core.Application.DTOs.Order;

namespace ECommerce.Core.Application.Abstractions.Services
{
	public interface IOrderService
    {
        Task<bool> CreateAsync(CreateOrder createOrder);
        Task<ListOrder> GetAllAsync();
        Task<SingleOrder> GetByIdAsync(int id);
        Task<bool> UpdateAsync(UpdateOrder updateOrder);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateStatusAsync(UpdateStatusOrder updateOrderStatus);
    }
}
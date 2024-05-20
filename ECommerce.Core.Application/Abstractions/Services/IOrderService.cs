using System;
using ECommerce.Core.Application.DTOs.Order;

namespace ECommerce.Core.Application.Abstractions.Services
{
	public interface IOrderService
    {
        Task CreateAsync(CreateOrder createOrder);
        ListOrder GetAll();
        Task<SingleOrder> GetByIdAsync(int id);
        Task UpdateAsync(UpdateOrder updateOrder);
        Task DeleteAsync(int id);
        Task UpdateStatusAsync(UpdateStatusOrder updateOrderStatus);
    }
}
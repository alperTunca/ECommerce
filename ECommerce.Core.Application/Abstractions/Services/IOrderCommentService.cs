using System;
using ECommerce.Core.Application.DTOs.OrderComment;

namespace ECommerce.Core.Application.Abstractions.Services
{
	public interface IOrderCommentService
    {
        Task CreateAsync(CreateOrderComment createOrderComment);
        ListOrderComment GetAll();
        Task<SingleOrderComment> GetByIdAsync(int id);
        Task UpdateAsync(UpdateOrderComment updateOrderComment);
        Task DeleteAsync(int id);
    }
}
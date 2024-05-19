﻿using System;
using ECommerce.Core.Application.DTOs.OrderComment;

namespace ECommerce.Core.Application.Abstractions.Services
{
	public interface IOrderCommentService
    {
        Task<bool> CreateAsync(CreateOrderComment createOrderComment);
        Task<ListOrderComment> GetAllAsync();
        Task<SingleOrderComment> GetByIdAsync(int id);
        Task<bool> UpdateAsync(UpdateOrderComment updateOrderComment);
        Task<bool> DeleteAsync(int id);
    }
}
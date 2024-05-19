using System;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;

namespace ECommerce.Infrastructure.Persistence.Services
{
    public class OrderCommentService : IOrderCommentService
    {
        private readonly IOrderCommentReadRepository _orderCommentReadRepository;
        private readonly IOrderCommentWriteRepository _orderCommentWriteRepository;

        public OrderCommentService(IOrderCommentReadRepository orderCommentReadRepository, IOrderCommentWriteRepository orderCommentWriteRepository)
        {
            _orderCommentReadRepository = orderCommentReadRepository;
            _orderCommentWriteRepository = orderCommentWriteRepository; 
        }

        public Task<bool> CreateAsync(CreateOrderComment createOrderComment)
        {
            throw new NotImplementedException();
        }

        public Task<ListOrderComment> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SingleOrderComment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UpdateOrderComment updateOrderComment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}


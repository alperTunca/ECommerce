using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Domain.Entities;

namespace ECommerce.Infrastructure.Persistence.Services
{
    public class OrderCommentService : IOrderCommentService
    {
        private readonly IOrderCommentReadRepository _orderCommentReadRepository;
        private readonly IOrderCommentWriteRepository _orderCommentWriteRepository;
        private readonly IMapper _mapper;

        public OrderCommentService(IOrderCommentReadRepository orderCommentReadRepository, IOrderCommentWriteRepository orderCommentWriteRepository, IMapper mapper)
        {
            _orderCommentReadRepository = orderCommentReadRepository;
            _orderCommentWriteRepository = orderCommentWriteRepository; 
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateOrderComment createOrderComment)
        {
            var mappedData = _mapper.Map<OrderComment>(createOrderComment);
            await _orderCommentWriteRepository.AddAsync(mappedData);
            await _orderCommentWriteRepository.SaveAsync();
        }

        public ListOrderComment GetAll()
        {
            var result = _orderCommentReadRepository.GetAll();
            var mappedData = _mapper.Map<ListOrderComment>(result);
            return mappedData;
        }

        public async Task<SingleOrderComment> GetByIdAsync(int id)
        {
            var result = await _orderCommentReadRepository.GetByIdAsync(id);
            var mappedData = _mapper.Map<SingleOrderComment>(result);
            return mappedData;
        }

        public async Task<bool> UpdateAsync(UpdateOrderComment updateOrderComment)
        {
            var data = await _orderCommentReadRepository.GetByIdAsync(updateOrderComment.Id);
            data.AccountId = updateOrderComment.AccountId;
            data.OrderId = updateOrderComment.OrderId;
            data.UserId = updateOrderComment.UserId;
            var mappedData = _mapper.Map<OrderComment>(updateOrderComment);
            var result = _orderCommentWriteRepository.Update(mappedData);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _orderCommentWriteRepository.Remove(id);
            return result;
        }
    }
}


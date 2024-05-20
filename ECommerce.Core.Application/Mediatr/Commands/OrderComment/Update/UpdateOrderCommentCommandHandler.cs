using AutoMapper;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using MediatR;
using System;
using System.Runtime.InteropServices;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Update
{
	public class UpdateOrderCommentCommandHandler : IRequestHandler<UpdateOrderCommentCommandRequest,  UpdateOrderCommentCommandResponse>
    {
        private readonly IOrderCommentReadRepository _orderCommentReadRepository;
        private readonly IOrderCommentWriteRepository _orderCommentWriteRepository;
        private readonly IMapper _mapper;

        public UpdateOrderCommentCommandHandler(IOrderCommentReadRepository orderCommentReadRepository, IOrderCommentWriteRepository orderCommentWriteRepository, IMapper mapper)
        {
            _orderCommentReadRepository = orderCommentReadRepository;
            _orderCommentWriteRepository = orderCommentWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateOrderCommentCommandResponse> Handle(UpdateOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var data = await _orderCommentReadRepository.GetByIdAsync(request.Id);
            data.AccountId = request.AccountId;
            data.OrderId = request.OrderId;
            data.UserId = request.UserId;
            data.Comment = request.Comment;
            _orderCommentWriteRepository.Update(data);
            await _orderCommentWriteRepository.SaveAsync();
            result = true;
            return new() { IsSuccess = result };
        }
    }
}


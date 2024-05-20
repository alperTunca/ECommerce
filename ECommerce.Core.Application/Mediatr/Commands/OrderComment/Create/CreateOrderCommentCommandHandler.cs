using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Create
{
	public class CreateOrderCommentCommandHandler : IRequestHandler<CreateOrderCommentCommandRequest, CreateOrderCommentCommandResponse>
	{
		private readonly IOrderCommentWriteRepository _orderCommentWriteRepository;
        private readonly IMapper _mapper;

        public CreateOrderCommentCommandHandler(IOrderCommentWriteRepository orderCommentWriteRepository, IMapper mapper)
        {
            _orderCommentWriteRepository = orderCommentWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateOrderCommentCommandResponse> Handle(CreateOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
			await _orderCommentWriteRepository.AddAsync(new() { AccountId = request.AccountId, UserId = request.UserId, OrderId = request.OrderId, Comment = request.Comment });
            await _orderCommentWriteRepository.SaveAsync();
            result = true;
			return new() { IsSuccess = result };
        }
    }
}


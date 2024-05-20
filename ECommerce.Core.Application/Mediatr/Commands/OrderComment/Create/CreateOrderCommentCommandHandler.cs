using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.OrderComment;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Create
{
	public class CreateOrderCommentCommandHandler : IRequestHandler<CreateOrderCommentCommandRequest, CreateOrderCommentCommandResponse>
	{
		private readonly IOrderCommentService _orderCommentService;
        private readonly IMapper _mapper;

        public CreateOrderCommentCommandHandler(IOrderCommentService orderCommentService, IMapper mapper)
        {
            _orderCommentService = orderCommentService;
            _mapper = mapper;
        }

        public async Task<CreateOrderCommentCommandResponse> Handle(CreateOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<CreateOrderComment>(request);
			await _orderCommentService.CreateAsync(mappedData);
			return new() { IsSuccess = true };
        }
    }
}


using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.DTOs.OrderComment;
using MediatR;
using System;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Update
{
	public class UpdateOrderCommentCommandHandler : IRequestHandler<UpdateOrderCommentCommandRequest,  UpdateOrderCommentCommandResponse>
    {
        private readonly IOrderCommentService _orderCommentService;
        private readonly IMapper _mapper;

        public UpdateOrderCommentCommandHandler(IOrderCommentService orderCommentService, IMapper mapper)
        {
            _orderCommentService = orderCommentService;
            _mapper = mapper;
        }

        public async Task<UpdateOrderCommentCommandResponse> Handle(UpdateOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<UpdateOrderComment>(request);
            await _orderCommentService.UpdateAsync(mappedData);
            return new() { IsSuccess = true };
        }
    }
}


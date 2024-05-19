using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Create
{
	public class CreateOrderCommentCommandHandler : IRequestHandler<CreateOrderCommentCommandRequest, CreateOrderCommentCommandResponse>
	{
		private readonly IOrderCommentService _orderCommentService;

		public CreateOrderCommentCommandHandler(IOrderCommentService orderCommentService)
		{
			_orderCommentService = orderCommentService;
		}

        public async Task<CreateOrderCommentCommandResponse> Handle(CreateOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
			// TODO - Fix
			var result = await _orderCommentService.CreateAsync(request.x);
			return new() { IsSuccess = result };
        }
    }
}


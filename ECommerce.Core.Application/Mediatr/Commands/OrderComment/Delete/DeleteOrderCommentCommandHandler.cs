using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Delete
{
	public class DeleteOrderCommentCommandHandler : IRequestHandler<DeleteOrderCommentCommandRequest, DeleteOrderCommentCommandResponse>
	{
		private readonly IOrderCommentService _orderCommentService;

		public DeleteOrderCommentCommandHandler(IOrderCommentService orderCommentService)
		{
			_orderCommentService = orderCommentService;
		}

        public async Task<DeleteOrderCommentCommandResponse> Handle(DeleteOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
			var result = await _orderCommentService.DeleteAsync(request.Id);
			return new() { IsSuccess = result };
        }
    }
}


using System;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Delete
{
	public class DeleteOrderCommentCommandHandler : IRequestHandler<DeleteOrderCommentCommandRequest, DeleteOrderCommentCommandResponse>
	{
		private readonly IOrderCommentWriteRepository _orderCommentWriteRepository;

		public DeleteOrderCommentCommandHandler(IOrderCommentWriteRepository orderCommentWriteRepository)
		{
            _orderCommentWriteRepository = orderCommentWriteRepository;
		}

        public async Task<DeleteOrderCommentCommandResponse> Handle(DeleteOrderCommentCommandRequest request, CancellationToken cancellationToken)
        {
			var result = false;
			await _orderCommentWriteRepository.Remove(request.Id);
			result = true;
			return new() { IsSuccess = true };
        }
    }
}


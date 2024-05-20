using System;
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
			var result = await _orderCommentWriteRepository.Remove(request.Id);
			await _orderCommentWriteRepository.SaveAsync();
			return new() { IsSuccess = result };
        }
    }
}


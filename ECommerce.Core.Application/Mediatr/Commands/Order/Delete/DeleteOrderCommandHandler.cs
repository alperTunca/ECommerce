using System;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Delete
{
	public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
	{
		private readonly IOrderWriteRepository _orderWriteRepository;

        public DeleteOrderCommandHandler(IOrderWriteRepository orderWriteRepository)
        {
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            await _orderWriteRepository.Remove(request.Id);
            await _orderWriteRepository.SaveAsync();
            result = true;
			return new() { IsSuccess = result };
        }
    }
}


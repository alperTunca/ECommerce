using System;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Delete
{
	public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommandRequest, DeleteOrderCommandResponse>
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;

        public DeleteOrderCommandHandler(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
        }

        public async Task<DeleteOrderCommandResponse> Handle(DeleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var data = await _orderReadRepository.GetWhere(x => x.AccountId == request.AccountId && x.OrderNumber == request.OrderNumber).FirstOrDefaultAsync();
            
            if(data == null) 
                return new() { IsSuccess = result };
            
            result = _orderWriteRepository.Remove(data);
            await _orderWriteRepository.SaveAsync();
			return new() { IsSuccess = result };
        }
    }
}


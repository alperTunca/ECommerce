using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;
using System;

namespace ECommerce.Core.Application.Mediatr.Queries.Order.GetById
{
	public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQueryRequest, GetByIdOrderQueryResponse>
	{
		private readonly IOrderReadRepository _orderReadRepository;

        public GetByIdOrderQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<GetByIdOrderQueryResponse> Handle(GetByIdOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _orderReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                AccountId = data.AccountId,
                OrderNumber = data.OrderNumber,
                OrderDate = data.OrderDate,
                OrderType = data.OrderType,
                Status = data.Status,
                SalesChannel = data.SalesChannel,
                City = data.City,
                District = data.District,
                Carrier = data.Carrier,
                UserId = data.UserId
            };
        }
    }
}


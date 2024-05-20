using ECommerce.Core.Application.Repositories.OrderRepositories;
using MediatR;
using System;

namespace ECommerce.Core.Application.Mediatr.Queries.Order.GetAll
{
	public class GetAllOrderQueryHandler : IRequestHandler<GetAllOrderQueryRequest, GetAllOrderQueryResponse>
	{
		public IOrderReadRepository _orderReadRepository;

        public GetAllOrderQueryHandler(IOrderReadRepository orderReadRepository)
        {
            _orderReadRepository = orderReadRepository;
        }

        public async Task<GetAllOrderQueryResponse> Handle(GetAllOrderQueryRequest request, CancellationToken cancellationToken)
        {
            var list = _orderReadRepository.GetAll();
            return new()
            {
                Orders = list,
            };
        }
    }
}


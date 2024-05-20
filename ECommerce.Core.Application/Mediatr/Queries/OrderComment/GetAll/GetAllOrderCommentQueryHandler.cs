using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using MediatR;
using System;

namespace ECommerce.Core.Application.Mediatr.Queries.OrderComment.GetAll
{
	public class GetAllOrderCommentQueryHandler : IRequestHandler<GetAllOrderCommentQueryRequest, GetAllOrderCommentQueryResponse>
	{
		private readonly IOrderCommentReadRepository _orderCommentReadRepository;

        public GetAllOrderCommentQueryHandler(IOrderCommentReadRepository orderCommentReadRepository)
        {
            _orderCommentReadRepository = orderCommentReadRepository;
        }

        public async Task<GetAllOrderCommentQueryResponse> Handle(GetAllOrderCommentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = _orderCommentReadRepository.GetAll();

            return new()
            {
                OrderComments = data
            };
        }
    }
}


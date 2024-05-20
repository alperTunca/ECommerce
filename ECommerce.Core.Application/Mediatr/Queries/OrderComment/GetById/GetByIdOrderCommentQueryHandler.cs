using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using MediatR;
using System;

namespace ECommerce.Core.Application.Mediatr.Queries.OrderComment.GetById
{
	public class GetByIdOrderCommentQueryHandler : IRequestHandler<GetByIdOrderCommentQueryRequest, GetByIdOrderCommentQueryResponse>
    {
		private readonly IOrderCommentReadRepository _orderCommentReadRepository;

        public GetByIdOrderCommentQueryHandler(IOrderCommentReadRepository orderCommentReadRepository)
        {
            _orderCommentReadRepository = orderCommentReadRepository;
        }

        public async Task<GetByIdOrderCommentQueryResponse> Handle(GetByIdOrderCommentQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _orderCommentReadRepository.GetByIdAsync(request.Id);

            return new()
            {
                AccountId = data.AccountId,
                Comment = data.Comment,
                OrderId = data.OrderId,
                UserId = data.UserId
            };
        }
    }
}


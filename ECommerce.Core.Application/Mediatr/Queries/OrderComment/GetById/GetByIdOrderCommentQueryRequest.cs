using MediatR;
using System;
namespace ECommerce.Core.Application.Mediatr.Queries.OrderComment.GetById
{
	public class GetByIdOrderCommentQueryRequest : IRequest<GetByIdOrderCommentQueryResponse>
    {
        public int Id { get; set; }
    }
}


using MediatR;
using System;
namespace ECommerce.Core.Application.Mediatr.Queries.Order.GetById
{
	public class GetByIdOrderQueryRequest : IRequest<GetByIdOrderQueryResponse>
    {
        public int Id { get; set; }
    }
}


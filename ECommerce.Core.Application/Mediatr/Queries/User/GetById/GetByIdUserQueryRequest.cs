using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Queries.User.GetById
{
	public class GetByIdUserQueryRequest : IRequest<GetByIdUserQueryResponse>
    {
		public int Id { get; set; }
	}
}


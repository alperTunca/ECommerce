using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.Order.Delete
{
	public class DeleteOrderCommandRequest : IRequest<DeleteOrderCommandResponse>
	{
		public int Id { get; set; }
	}
}


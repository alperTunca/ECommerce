using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Delete
{
	public class DeleteOrderCommentCommandRequest : IRequest<DeleteOrderCommentCommandResponse>
	{
		public int Id { get; set; }
	}
}


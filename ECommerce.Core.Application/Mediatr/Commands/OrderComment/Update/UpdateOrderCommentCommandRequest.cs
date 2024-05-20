using MediatR;
using System;
namespace ECommerce.Core.Application.Mediatr.Commands.OrderComment.Update
{
	public class UpdateOrderCommentCommandRequest : IRequest<UpdateOrderCommentCommandResponse>
	{
		public UpdateOrderCommentCommandRequest()
		{
		}
	}
}


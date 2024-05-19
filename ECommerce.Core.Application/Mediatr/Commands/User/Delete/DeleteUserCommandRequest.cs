using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Delete
{
	public class DeleteUserCommandRequest : IRequest<DeleteUserCommandResponse>
	{
		public int Id { get; set; }
	}
}


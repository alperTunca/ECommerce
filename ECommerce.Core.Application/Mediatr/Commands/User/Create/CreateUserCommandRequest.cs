using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Create
{
	public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
	{
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}


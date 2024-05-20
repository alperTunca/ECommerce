using System;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Update
{
	public class UpdateUserCommandRequest : IRequest<UpdateUserCommandResponse>
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}


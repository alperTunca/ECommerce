using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Delete
{
	public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
	{
		private readonly IUserService _userService;

		public DeleteUserCommandHandler(IUserService userService)
		{
			_userService = userService;
		}

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
			await _userService.DeleteAsync(request.Id);
			return new() { IsSuccess = true };
        }
    }
}


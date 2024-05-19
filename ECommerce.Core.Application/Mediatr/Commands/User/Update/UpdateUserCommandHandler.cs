using System;
using ECommerce.Core.Application.Abstractions.Services;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Update
{
	public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
	{
		private readonly IUserService _userService;

		public UpdateUserCommandHandler(IUserService userService)
		{
			_userService = userService;
		}

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
			var result = await _userService.UpdateAsync(request);
			return new() { IsSuccess = result };
        }
    }
}


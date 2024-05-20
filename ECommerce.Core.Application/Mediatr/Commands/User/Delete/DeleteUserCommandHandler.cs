using System;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Delete
{
	public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
	{
		private readonly IUserWriteRepository _userWriteRepository;

		public DeleteUserCommandHandler(IUserWriteRepository userWriteRepository)
		{
			_userWriteRepository = userWriteRepository;
		}

        public async Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
			var result = false;
			await _userWriteRepository.Remove(request.Id);
			result = true;
			return new() { IsSuccess = result };
        }
    }
}


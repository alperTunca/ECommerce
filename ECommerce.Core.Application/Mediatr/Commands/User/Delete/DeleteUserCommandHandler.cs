using System;
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
            var result = await _userWriteRepository.Remove(request.Id);
			await _userWriteRepository.SaveAsync();
		
			return new() { IsSuccess = result };
        }
    }
}


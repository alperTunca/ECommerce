using System;
using AutoMapper;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Create
{
	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
	{
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IUserWriteRepository userWriteRepository, IMapper mapper)
        {
            _userWriteRepository = userWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            bool result = false;
            await _userWriteRepository.AddAsync(new() { Email = request.Email, Password = request.Email, Username = request.Username});
            
            await _userWriteRepository.SaveAsync();
            result = true;

            return new() { IsSuccess = result };
        }
    }
}


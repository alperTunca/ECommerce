using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Create
{
	public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
	{
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public CreateUserCommandHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<CreateUser>(request);
            await _userService.CreateAsync(mappedData);
            return new() { IsSuccess = true };
        }
    }
}


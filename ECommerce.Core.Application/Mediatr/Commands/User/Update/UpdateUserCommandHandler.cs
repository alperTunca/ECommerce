using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.User;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Update
{
	public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
	{
		private readonly IUserService _userService;
		private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var mappedData = _mapper.Map<UpdateUser>(request);
			await _userService.UpdateAsync(mappedData);
			return new() { IsSuccess = true };
        }
    }
}


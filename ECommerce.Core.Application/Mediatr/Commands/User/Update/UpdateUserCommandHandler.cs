using System;
using AutoMapper;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Commands.User.Update
{
	public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, UpdateUserCommandResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository, IMapper mapper)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
            _mapper = mapper;
        }

        public async Task<UpdateUserCommandResponse> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var result = false;
            var data = await _userReadRepository.GetByIdAsync(request.Id);
            data.Username = request.Username;
            data.Email = request.Email;
            data.Password = request.Password;
            _userWriteRepository.Update(data);
            await _userWriteRepository.SaveAsync();
            result = true;
            return new() { IsSuccess = result };
        }
    }
}


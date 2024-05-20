using System;
using AutoMapper;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Queries.User.GetById
{
	public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQueryRequest, GetByIdUserQueryResponse>
    {
        readonly IUserReadRepository _userReadRepo;

		public GetByIdUserQueryHandler(IUserReadRepository userReadRepository) 
		{
            _userReadRepo = userReadRepository;
		}

        public async Task<GetByIdUserQueryResponse> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _userReadRepo.GetByIdAsync(request.Id);
            return new()
            {
                Email = data.Email,
                Username = data.Username,
                Password = data.Password
            };
        }
    }
}


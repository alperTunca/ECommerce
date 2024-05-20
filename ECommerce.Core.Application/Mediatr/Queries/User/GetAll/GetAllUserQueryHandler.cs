using AutoMapper;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Queries.User.GetAll
{
	public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
	{
		readonly IUserReadRepository _userReadRepo;

		public GetAllUserQueryHandler(IUserReadRepository userReadRepository)
		{
			_userReadRepo = userReadRepository;
		}

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
			var data = _userReadRepo.GetAll();

			return new() { Users = data };
        }
    }
}


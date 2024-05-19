using AutoMapper;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;
using MediatR;

namespace ECommerce.Core.Application.Mediatr.Queries.User.GetAll
{
	public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
	{
		readonly IUserReadRepository _userReadRepo;
		readonly IMapper _mapper;

		public GetAllUserQueryHandler(IUserReadRepository userReadRepository, IMapper mapper)
		{
			_userReadRepo = userReadRepository;
			_mapper = mapper;
		}

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
			var data = _userReadRepo.GetAll().ToList();
			var result = _mapper.Map<List<SingleUser>>(data);

			return new() { Users = result };
        }
    }
}


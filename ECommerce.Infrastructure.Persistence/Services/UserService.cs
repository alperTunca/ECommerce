using System;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;

namespace ECommerce.Infrastructure.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public UserService(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }

        public Task<bool> CreateAsync(CreateUser createUser)
        {
            throw new NotImplementedException();
        }

        public Task<ListUser> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SingleUser> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UpdateUser updateUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}


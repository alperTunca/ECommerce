using System;
using AutoMapper;
using ECommerce.Core.Application.Abstractions.Services;
using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;

namespace ECommerce.Infrastructure.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IMapper _mapper;

        public UserService(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository, IMapper mapper)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateUser createUser)
        {
            var mappedData = _mapper.Map<User>(createUser);
            await _userWriteRepository.AddAsync(mappedData);
            await _userWriteRepository.SaveAsync();
        }

        public ListUser GetAll()
        {
            var result = _userReadRepository.GetAll().ToList();
            var mappedData = _mapper.Map<ListUser>(result);
            return mappedData;
        }

        public async Task<SingleUser> GetByIdAsync(int id)
        {
            var result = await _userReadRepository.GetByIdAsync(id);
            var mappedData = _mapper.Map<SingleUser>(result);
            return mappedData;
        }

        public async Task UpdateAsync(UpdateUser updateUser)
        {
            var data = await _userReadRepository.GetByIdAsync(updateUser.Id);
            data.Username = updateUser.Username;
            data.Email = updateUser.Email;
            data.Password = updateUser.Password;
            _userWriteRepository.Update(data);
            await _userWriteRepository.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _userWriteRepository.Remove(id);
            await _userWriteRepository.SaveAsync();
        }
    }
}


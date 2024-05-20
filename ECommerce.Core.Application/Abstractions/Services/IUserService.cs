using System;
using ECommerce.Core.Application.DTOs.User;

namespace ECommerce.Core.Application.Abstractions.Services
{
	public interface IUserService
    {
        Task CreateAsync(CreateUser createUser);
        ListUser GetAll();
        Task<SingleUser> GetByIdAsync(int id);
        Task UpdateAsync(UpdateUser updateUser);
        Task DeleteAsync(int id);
    }
}
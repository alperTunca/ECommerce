using System;
using ECommerce.Core.Application.DTOs.User;

namespace ECommerce.Core.Application.Abstractions.Services
{
	public interface IUserService
    {
        Task<bool> CreateAsync(CreateUser createUser);
        ListUser GetAll();
        Task<SingleUser> GetByIdAsync(int id);
        Task<bool> UpdateAsync(UpdateUser updateUser);
        Task<bool> DeleteAsync(int id);
    }
}
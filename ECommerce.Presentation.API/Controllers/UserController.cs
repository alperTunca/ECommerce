using ECommerce.Core.Application.DTOs.User;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserReadRepository _userReadRepo;
        private readonly IUserWriteRepository _userWriteRepo;

        public UserController(IUserReadRepository userReadRepo, IUserWriteRepository userWriteRepo)
        {
            _userReadRepo = userReadRepo;
            _userWriteRepo = userWriteRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUser createUser)
        {
            var data = new User
            {
                Username = createUser.Username,
                Email = createUser.Email,
                Password = createUser.Password
            };
            await _userWriteRepo.AddAsync(data);
            await _userWriteRepo.SaveAsync();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _userReadRepo.GetAll();
            return Ok(list);
        }

        [HttpPut]
        public IActionResult Update(UpdateUser updateUser)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}

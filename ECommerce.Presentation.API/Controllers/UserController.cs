using ECommerce.Core.Application.Repositories.UserRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _userReadRepo.GetAll();
            return Ok(list);
        }

        [HttpPut]
        public IActionResult Update()
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

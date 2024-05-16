using ECommerce.Core.Application.Repositories.OrderRepositories;
using ECommerce.Core.Application.Repositories.UserRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderReadRepository _orderReadRepo;
        private readonly IOrderWriteRepository _orderWriteRepo;

        public OrderController(IOrderReadRepository orderReadRepo, IOrderWriteRepository orderWriteRepo)
        {
            _orderReadRepo = orderReadRepo;
            _orderWriteRepo = orderWriteRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("1");
        }
    }
}

using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Application.Repositories.UserRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderCommentController : ControllerBase
    {
        private readonly IOrderCommentReadRepository _orderCommentReadRepo;
        private readonly IOrderCommentWriteRepository _orderCommentWriteRepo;

        public OrderCommentController(IOrderCommentReadRepository orderCommentReadRepo, IOrderCommentWriteRepository orderCommentWriteRepo)
        {
            _orderCommentReadRepo = orderCommentReadRepo;
            _orderCommentWriteRepo = orderCommentWriteRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("1");
        }
    }
}

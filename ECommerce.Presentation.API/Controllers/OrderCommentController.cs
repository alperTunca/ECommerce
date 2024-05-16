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

        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _orderCommentReadRepo.GetAll();
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

using ECommerce.Core.Application.DTOs.OrderComment;
using ECommerce.Core.Application.Repositories.OrderCommentRepositories;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]/[action]")]
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
        public async Task<IActionResult> Create(CreateOrderComment createOrderComment)
        {
            var data = new OrderComment {
                Comment = createOrderComment.Comment,
                UserId = createOrderComment.UserId,
                OrderId = createOrderComment.OrderId
            };
            await _orderCommentWriteRepo.AddAsync(data);
            await _orderCommentWriteRepo.SaveAsync();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _orderCommentReadRepo.GetAll();
            return Ok(list);
        }

        [HttpPut]
        public IActionResult Update(UpdateOrderComment updateOrderComment)
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

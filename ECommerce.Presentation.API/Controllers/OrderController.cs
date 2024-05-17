using ECommerce.Core.Application.DTOs.Order;
using ECommerce.Core.Application.Repositories.OrderRepositories;
using ECommerce.Core.Application.Repositories.UserRepositories;
using ECommerce.Core.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]/[action]")]
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

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrder createOrder)
        {
            var data = new Order
            {
                AccountId = createOrder.AccountId,
                OrderNumber = createOrder.OrderNumber,
                OrderDate = createOrder.OrderDate,
                OrderType = createOrder.OrderType,
                Status = createOrder.Status,
                SalesChannel = createOrder.SalesChannel,
                City = createOrder.City,
                District = createOrder.District,
                Carrier = createOrder.Carrier,
                UserId = createOrder.UserId,
            };
            await _orderWriteRepo.AddAsync(data);
            await _orderWriteRepo.SaveAsync();
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _orderReadRepo.GetAll();
            return Ok(list);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateOrder updateOrder)
        {
            var data = new Order
            {
                AccountId = updateOrder.AccountId,
                OrderNumber = updateOrder.OrderNumber,
                OrderType = updateOrder.OrderType,
                Status = updateOrder.Status,
                SalesChannel = updateOrder.SalesChannel,
                City = updateOrder.City,
                District = updateOrder.District
            };
            _orderWriteRepo.Update(data);
            await _orderWriteRepo.SaveAsync();
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStatus(UpdateStatusOrder updateStatusOrder)
        {
            return Ok();
        }
    }
}

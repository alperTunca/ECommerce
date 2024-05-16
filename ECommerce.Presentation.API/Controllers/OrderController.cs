using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("1");
        }
    }
}

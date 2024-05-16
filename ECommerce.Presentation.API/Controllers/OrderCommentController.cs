using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderCommentController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("1");
        }
    }
}

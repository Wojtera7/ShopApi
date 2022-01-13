using Microsoft.AspNetCore.Mvc;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("/ping")]
        public IActionResult Get()
        {
            return Ok(new { Response = "Pong" });
        }
    }
}

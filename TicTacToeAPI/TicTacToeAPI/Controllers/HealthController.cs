using Microsoft.AspNetCore.Mvc;

namespace TicTacToeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : Controller
    {   
        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

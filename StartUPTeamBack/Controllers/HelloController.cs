using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StartUPTeamBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, StartUP Team!");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StartUPTeamBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(new {message = "Hello, StartUP Team"});
        }
    }
}

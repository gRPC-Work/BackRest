using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackRest.Controllers
{
    [Route("api/v1/[controller]")]
    public class TestController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("connection")]
        public IActionResult ConnectionAsync() => Ok(new
        {
            Data = "Hello!"
        });
    }
}
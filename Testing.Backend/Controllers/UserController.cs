using Microsoft.AspNetCore.Mvc;

namespace Testing.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "")]
        public ActionResult Get()
        {
            return Ok();
        }
    }
}
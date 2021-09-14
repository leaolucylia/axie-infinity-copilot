using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace copilot_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MatchController : ControllerBase
    {
        private readonly ILogger<MatchController> _logger;

        public MatchController(ILogger<MatchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {

        }
    }
}

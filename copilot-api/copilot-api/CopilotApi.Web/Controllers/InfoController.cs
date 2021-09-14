using CopilotApi.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace copilot_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("card")]
        public async Task<IActionResult> GetCard([FromServices] ICardService cardService)
        {
            try
            {
                var cards = await cardService.Get();

                return Ok(cards);
            }
            catch (Exception exception)
            {
                _logger.LogError("Create match error.", exception);
                throw;
            }
        }
    }
}

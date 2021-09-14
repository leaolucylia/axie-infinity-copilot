using CopilotApi.Application.Match;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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

        [HttpPost]
        public async Task<IActionResult> Create(
            [FromServices] IMatchService matchService,
            [FromBody] MatchRequest matchRequest)
        {
            try
            {
                var matchId = await matchService.Create(matchRequest.OwnerTeamId);
                _ = matchRequest.Opponent.Select(async o => await matchService.AddOpponent(matchId, o.Position, o.Type, o.Cards));

                return Created(string.Empty, matchId);
            }
            catch (Exception exception)
            {
                _logger.LogError("Create match error.", exception);
                throw;
            }
        }

        public class MatchRequest
        {
            public long OwnerTeamId { get; set; }
            public IEnumerable<AxieRequest> Opponent { get; set; }

            public class AxieRequest
            {
                public string Position { get; set; }
                public string Type { get; set; }
                public IEnumerable<long> Cards { get; set; }
            }
        }
    }
}

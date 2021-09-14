using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopilotApi.Application.Match
{
    public interface IMatchService
    {
        Task<long> Create(long ownerTeamId);
        Task AddOpponent(long matchId, string position, string type, IEnumerable<long> cards);
    }

    public class MatchService : IMatchService
    {
        //private readonly ILogger<MatchService> _logger;

        //public MatchService(ILogger<MatchService> logger)
        //{
        //    _logger = logger;
        //}

        public Task<long> Create(long ownerTeamId)
        {
            throw new NotImplementedException();
        }

        public Task AddOpponent(long matchId, string position, string type, IEnumerable<long> cards)
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace CopilotApi.Domain.Match
{
    public class Match
    {
        public Match(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; }

        public Player Owner { get; }

        public Player Opponent { get; }
    }
}

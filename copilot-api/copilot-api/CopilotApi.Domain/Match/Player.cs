using System.Collections.Generic;

namespace CopilotApi.Domain.Match
{
    public class Player
    {
        public IEnumerable<Card> Cards { get; }

        public int Energy { get; }

    }
}

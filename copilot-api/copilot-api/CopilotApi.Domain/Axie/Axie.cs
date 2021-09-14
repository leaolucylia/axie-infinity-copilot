using System.Collections.Generic;

namespace CopilotApi.Domain
{
    public class Axie
    {
        public AxieType Type { get; }
        public IEnumerable<Card> Cards { get; }
        public int Health { get; }
        public int Morale { get; }
        public int Speed { get; }
        public int Skill { get; }
    }
}

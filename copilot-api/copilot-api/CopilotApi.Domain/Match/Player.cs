namespace CopilotApi.Domain
{
    public class Player
    {
        const int _energyStart = 3;

        public int Energy { get; }

        public Deck Deck { get; }

        public Player()
        {
            Energy = _energyStart;
        }
    }
}

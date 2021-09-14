using System.Collections.Generic;

namespace CopilotApi.Domain
{
    public class Deck
    {
        const int _cardInHandStart = 6;
        const int _cardInHandLimit = 9;
        const int _limitDeckCount = 24;

        public int CardInHandCount { get; }

        public IEnumerable<Card> Cards { get; }

        public IEnumerable<Card> DiscardPile { get; }
    }
}

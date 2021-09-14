using CopilotApi.Domain.Axie;
using CopilotApi.Domain.Card;

namespace CopilotApi.Domain.Match
{
    public class Card
    {
        public string Name { get; }
        public string BodyName { get; }
        public AxieType AxieType { get; }
        public BodyPart BodyPart { get; }
        public int EnergyCost { get; }
        public int Damage { get; }
        public int Shield { get; }
        public Buff Buff { get; }
        public Debuff Debuff { get; }

        public Card(int cost, int damage, int shield)
        {
            EnergyCost = cost;
            Damage = damage;
            Shield = shield;
        }
    }
}

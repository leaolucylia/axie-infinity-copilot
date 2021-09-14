using CopilotApi.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopilotApi.Infra
{
    public class CardRepository : ICardRepository
    {
        public async Task<IEnumerable<Card>> Get()
        {
            return new List<Card>()
            {
                 new Card(1, "Imp", "Ivory Stab", "Gain 1 energy when your team score a critical hit", AxieType.Beast, BodyPart.Horn, 1, 70, 40, Buff.None, Debuff.None)
            };
        }
    }
}

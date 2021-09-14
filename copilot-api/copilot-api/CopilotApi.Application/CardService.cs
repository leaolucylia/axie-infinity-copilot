using CopilotApi.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopilotApi.Application
{
    public interface ICardService
    {
        Task<IEnumerable<Card>> Get();
    }

    public class CardService : ICardService
    {
        private readonly ICardRepository _cardRepository;

        public CardService(ICardRepository CardRepository)
        {
            _cardRepository = CardRepository;
        }

        public async Task<IEnumerable<Card>> Get()
        {
            return await _cardRepository.Get();
        }
    }
}

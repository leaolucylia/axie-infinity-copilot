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
        public async Task<IEnumerable<Card>> Get()
        {
            throw new System.NotImplementedException();
        }
    }
}

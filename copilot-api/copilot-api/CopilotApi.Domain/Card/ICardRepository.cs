using System.Collections.Generic;
using System.Threading.Tasks;

namespace CopilotApi.Domain
{
    public interface ICardRepository
    {
        Task<IEnumerable<Card>> Get();
    }
}

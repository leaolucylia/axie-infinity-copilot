using System.Threading.Tasks;

namespace CopilotApi.Application.Match
{
    public interface IMatchService
    {
        Task Create();
    }

    public class MatchService : IMatchService
    {
        public MatchService()
        {

        }

        public Task Create()
        {
            throw new System.NotImplementedException();
        }
    }
}

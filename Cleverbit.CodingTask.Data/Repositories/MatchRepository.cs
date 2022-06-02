using Cleverbit.CodingTask.Domain.Entities;
using Cleverbit.CodingTask.Domain.Interfaces;

namespace Cleverbit.CodingTask.Data.Repositories
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(CodingTaskContext context) : base(context)
        {
        }
    }
}

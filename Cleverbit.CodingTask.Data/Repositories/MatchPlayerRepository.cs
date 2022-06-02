using Cleverbit.CodingTask.Domain.Contracts.Models;
using Cleverbit.CodingTask.Domain.Entities;
using Cleverbit.CodingTask.Domain.Interfaces;

namespace Cleverbit.CodingTask.Data.Repositories
{
    public class GamePlayerRepository : GenericRepository<GamePlayer>, IGamePlayerRepository
    {
        public GamePlayerRepository(CodingTaskContext context) : base(context)
        {
        }
    }
}

using Cleverbit.CodingTask.Domain.Entities;
using Cleverbit.CodingTask.Domain.Interfaces;

namespace Cleverbit.CodingTask.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CodingTaskContext context) : base(context)
        {
        }
    }
}

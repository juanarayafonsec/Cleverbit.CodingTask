using System.Collections.Generic;

namespace Cleverbit.CodingTask.Domain.Contracts.Models
{
    public  class GamesInfo
    {
        public string GameName { get; set; }
        public IEnumerable<Player> Winners { get; set; }
    }
}

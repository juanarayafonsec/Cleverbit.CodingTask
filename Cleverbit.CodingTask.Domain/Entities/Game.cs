using System;
using System.Collections.Generic;
using System.Text;

namespace Cleverbit.CodingTask.Domain.Entities
{
    public class Game
    {
        public Guid Id { get; set; }
        public int WinnerNumber { get; set; }
        public DateTimeOffset Expiry { get; set; }
        public ICollection<GamePlayer> GamePlayer { get; set; }
    }
}

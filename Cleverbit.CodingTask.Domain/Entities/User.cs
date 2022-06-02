﻿using System.Collections.Generic;

namespace Cleverbit.CodingTask.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<GamePlayer> GameScores { get; set; }
    }
}

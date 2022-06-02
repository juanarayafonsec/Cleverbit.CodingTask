using System;

namespace Cleverbit.CodingTask.Domain.Entities
{
    public  class GamePlayer
    {
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Number { get; set; }
    }
}

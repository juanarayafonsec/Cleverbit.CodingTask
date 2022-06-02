using Cleverbit.CodingTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cleverbit.CodingTask.Data
{
    public class CodingTaskContext : DbContext
    {
        public CodingTaskContext(DbContextOptions<CodingTaskContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Gamees { get; set; }
        public DbSet<GamePlayer> GameScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<GamePlayer>()
             .HasKey(ms => new { ms.GameId, ms.UserId });
             modelBuilder.Entity<GamePlayer>()
                 .HasOne(ms => ms.Game)
                 .WithMany(m => m.GamePlayer)
                 .HasForeignKey(ms => ms.GameId);
             modelBuilder.Entity<GamePlayer>()
                 .HasOne(ms => ms.User)
                 .WithMany(u => u.GameScores)
                 .HasForeignKey(ms => ms.UserId);
         }
    }
}

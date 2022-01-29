using AI_Uzd_1_API.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new SportsConfiguration());
            builder.ApplyConfiguration(new TeamsConfiguration());
            builder.ApplyConfiguration(new PlayersConfiguration());

        }
    }
}

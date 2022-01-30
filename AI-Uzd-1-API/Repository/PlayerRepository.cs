using AI_Uzd_1_API.IRepository;
using AI_Uzd_1_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Repository
{
    public class PlayerRepository : IPlayersRepository
    {
        private DatabaseContext context;
        private DbSet<Player> _players;
        public PlayerRepository(DatabaseContext database)
        {
            context = database;
            _players = context.Set<Player>();
        }

        public async Task AddPlayer(Player player)
        {
            await _players.AddAsync(player);
        }

        public async Task DeletePlayer(int id)
        {
            var player = await _players.FindAsync(id);
            _players.Remove(player);
        }

        public async Task<Player> GetPlayer(int id)
        {
            return await _players.Include(p => p.Team).ThenInclude(t => t.Sport).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<Player>> GetPlayers()
        {
            return await _players.Include(p => p.Team).ThenInclude(t => t.Sport).ToListAsync();
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public void UpdatePlayer(Player player)
        {
            context.Entry(player).State = EntityState.Modified;
        }
        
    }
}

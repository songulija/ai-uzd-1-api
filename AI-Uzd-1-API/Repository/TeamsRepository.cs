using AI_Uzd_1_API.IRepository;
using AI_Uzd_1_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.Repository
{
    public class TeamsRepository : ITeamsRepository
    {
        private DatabaseContext context;
        private DbSet<Team> _teams;
        public TeamsRepository(DatabaseContext database)
        {
            context = database;
            _teams = context.Set<Team>();
        }

        public async Task AddTeam(Team team)
        {
            await _teams.AddAsync(team);
        }

        public async Task DeleteTeam(int id)
        {
            var team = await _teams.FindAsync(id);
            _teams.Remove(team);
        }

        public async Task<Team> GetTeam(int id)
        {
            return await _teams.Include(t => t.Players).SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IList<Team>> GetTeams()
        {
            return await _teams.Include(t => t.Players).ToListAsync();
        }
        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public void UpdateTeam(Team team)
        {
            context.Entry(team).State = EntityState.Modified;
        }
    }
}

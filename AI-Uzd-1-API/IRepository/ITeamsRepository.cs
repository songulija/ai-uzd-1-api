using AI_Uzd_1_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.IRepository
{
    public interface ITeamsRepository
    {
        Task<IList<Team>> GetTeams();
        Task<Team> GetTeam(int id);
        Task AddTeam(Team team);
        void UpdateTeam(Team team);
        Task DeleteTeam(int id);
        Task Save();
    }
}

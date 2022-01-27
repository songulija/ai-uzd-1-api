using AI_Uzd_1_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AI_Uzd_1_API.IRepository
{
    public interface IPlayersRepository
    {
        Task<IList<Player>> GetPlayers();
        Task<Player> GetPlayer(int id);
        Task AddPlayer(Player player);
        void UpdatePlayer(Player player);
        Task DeletePlayer(int id);
        Task Save();
    }
}

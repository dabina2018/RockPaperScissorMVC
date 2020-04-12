using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissor2.Models;

namespace RockPaperScissor2.Services
{
    public interface IDataService
    {
        List<Player> PlayersList { get; set; }
        List<Player> PlayersInitializeData();
        Player GetPlayerById(int? id);
        void AddPlayer(Player player);
    }
}

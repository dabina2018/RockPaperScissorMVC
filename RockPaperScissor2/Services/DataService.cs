using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissor2.Models;

namespace RockPaperScissor2.Services
{
    public class DataService : IDataService
    {
        public List<Player> PlayersList { get; set; }
        public void AddPlayer (Player player)
        {
            PlayersList.Add(player);
        }

        public List<Player> PlayersInitializeData()
        {
            PlayersList = new List<Player>()
            {
                new Player(){Id = 1, PlayerName = "Player One", PlayerEmail = "player1@domain.com", PlayerOutcome = Outcome.Lose},
                new Player(){Id = 1, PlayerName = "Player Two", PlayerEmail = "player2@domain.com", PlayerOutcome = Outcome.Lose},
                new Player(){Id = 1, PlayerName = "Player Three", PlayerEmail = "player3@domain.com", PlayerOutcome = Outcome.Lose}
            };
            return PlayersList;
        }

        public Player GetPlayerById(int? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return PlayersList.SingleOrDefault(a => a.Id == id);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissor2.Models
{
    public class Player
    {
        public int Id { get; set; }


        public string PlayerName { get; set; }
        public string PlayerEmail { get; set; }
        public Outcome? PlayerOutcome { get; set; }

       
    }
}

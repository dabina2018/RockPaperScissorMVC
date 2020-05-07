using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class PlayerModel
    {
        private int playerId;
        public string playerName = "Your Name";
        public string playerEmail = "you@domain.com";
        public bool Win { get; set; }
    }
}

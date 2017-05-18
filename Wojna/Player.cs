using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojna
{
    class Player
    {
        private string playerName;
        public List<Card> Deck;        
        public Player(string name) {
            playerName = name;
            Deck = new List<Card>();
        }
    }
}

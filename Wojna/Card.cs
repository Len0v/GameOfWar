using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojna
{
    public enum CardEnum
    {
        Deuce = 1,
        Three = 2,
        Four = 3,
        Five = 4,
        Six = 5,
        Seven = 6,
        Eight = 7,
        Nine = 8,
        Ten = 9,
        Jack = 10,
        Queen = 11,
        King = 12,
        Ace = 13
    }
    public class Card
    {
        string name;
        int power;
        public Card(CardEnum card)
        {
            this.name = card.ToString();
            this.power = (int)card;
        }

        public string GetName()
        {
            return name;
        }
        public int GetPower()
        {
            return power;
        }
    }
}


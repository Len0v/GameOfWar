using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojna
{
    class Deck
    {
        public List<Card> deck;
        public Deck()
        {
            deck = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                deck.Add(new Card(CardEnum.Deuce));
                deck.Add(new Card(CardEnum.Three));
                deck.Add(new Card(CardEnum.Four)); 
                deck.Add(new Card(CardEnum.Five));
                deck.Add(new Card(CardEnum.Six));
                deck.Add(new Card(CardEnum.Seven));
                deck.Add(new Card(CardEnum.Eight));
                deck.Add(new Card(CardEnum.Nine));
                deck.Add(new Card(CardEnum.Ten));
                deck.Add(new Card(CardEnum.Jack));
                deck.Add(new Card(CardEnum.Queen));
                deck.Add(new Card(CardEnum.King));
                deck.Add(new Card(CardEnum.Ace));
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }           
        }
    }
}

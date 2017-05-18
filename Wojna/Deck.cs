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
                /*
                deck.Add(new Card("Deuce", 1));
                deck.Add(new Card("Three", 2));
                deck.Add(new Card("Four", 3)); 
                deck.Add(new Card("Five", 4));
                deck.Add(new Card("Six", 5));
                deck.Add(new Card("Seve", 6));
                deck.Add(new Card("Eight", 7));
                deck.Add(new Card("Nine", 8));
                deck.Add(new Card("Ten", 9));
                deck.Add(new Card("Jack", 10));
                deck.Add(new Card("Queen", 11));
                deck.Add(new Card("King", 12));
                deck.Add(new Card("Ace", 13));
                 */
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojna
{
    class Game
    {
        Deck StartingDeck;
        List<Card> warCards;
        Player p1;
        Player p2;
        public Game(Player player1, Player player2)
        {            
            p1 = player1;
            p2 = player2;
            StartingDeck = new Deck();
            StartingDeck.ShuffleDeck();
            warCards = new List<Card>();
            dealCards();           
        }

        public void Play(int times = 0)
        {
            var timesPlayed = 1;
            if(times != 0)
            {
                for (int t = 0; t < times; t++)
                {
                    if(p1.Deck.Count == 0 || p2.Deck.Count == 0)
                    {
                        Console.WriteLine("Game Ended! TP:" + timesPlayed + " P1:" + p1.Deck.Count + " P2:" + p2.Deck.Count);
                        break;
                    }
                    Console.WriteLine("TP: " + timesPlayed + "P1: " + p1.Deck.First().GetName() + " P2: " + p2.Deck.First().GetName());
                    GetResult(p1.Deck.First(), p2.Deck.First());
                    Console.WriteLine("P1 deck:" + p1.Deck.Count + " P2 deck:" + p2.Deck.Count);
                    timesPlayed += 1;
                }
            }
            else
            {
                while(p1.Deck.Count != 0 || p2.Deck.Count != 0)
                {
                    Console.WriteLine("TP: " + timesPlayed + "P1: " + p1.Deck.First().GetName() + " P2: " + p2.Deck.First().GetName());
                    GetResult(p1.Deck.First(), p2.Deck.First());
                    Console.WriteLine("P1 deck:" + p1.Deck.Count + " P2 deck:" + p2.Deck.Count);
                    timesPlayed += 1;
                }
                Console.WriteLine("Game Ended! TP:" + timesPlayed + " P1: " + p1.Deck.Count + " P2: " + p2.Deck.Count);                
            }
        }

        void dealCards()
        {
            int i = 0;
            foreach (var card in StartingDeck.deck)
            {                
                if (i % 2 == 0)
                {
                    p1.Deck.Add(card);
                    p1.Deck.Reverse();
                }
                else if (i%2 == 1)
                {
                    p2.Deck.Add(card);
                    p2.Deck.Reverse();
                }
                i++;
            }
        }
        
        int GetResult(Card c1, Card c2)
        {
            if (c1.GetPower() > c2.GetPower())
            {
                Player1Win();
                return 1;
            }
            else if (c1.GetPower() < c2.GetPower())
            {
                Player2Win();
                return 2;
            }
            else
            {
                Console.WriteLine("WAR !!!");
                War();
                return 0;
            }
        }

        void Player1Win()
        {
            p1.Deck.Add(p2.Deck.First());
            p1.Deck.Add(p1.Deck.First());
            p2.Deck.RemoveAt(0);
            p1.Deck.RemoveAt(0);
        }
        
        void Player2Win()
        {
            p2.Deck.Add(p1.Deck.First());
            p2.Deck.Add(p2.Deck.First());
            p1.Deck.RemoveAt(0);
            p2.Deck.RemoveAt(0);
            
        }

        void War()
        {            
            warCards.Add(p1.Deck.First());            
            warCards.Add(p1.Deck.First());
            p1.Deck.RemoveRange(0, 2);
            warCards.Add(p2.Deck.First());
            warCards.Add(p2.Deck.First());
            p2.Deck.RemoveRange(0, 2);

            var result = GetResult(p1.Deck.First(), p2.Deck.First());
            if(result == 1)
            {
                foreach(var card in warCards)
                {
                    p1.Deck.Add(card);
                }
                warCards.Clear();
            }
            else if (result == 2)
            {
                foreach (var card in warCards)
                {
                    p2.Deck.Add(card);
                }
                warCards.Clear();
            }            
        }


    }
}

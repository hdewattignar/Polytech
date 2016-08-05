using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeGame
{
    class Deck
    {
        private Card[] deck;
        private string[] suit;
        private string[] value;        

        public Deck()
        {
            deck = new Card[52];
            suit = new string[] {"H", "C", "S", "D"};
            value = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };

            CreateDeck();
            Shuffle();
        }

        public void CreateDeck()
        {
            int count = 0;

            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    deck[count++] = new Card(suit[i], value[j]);
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            
            for (int i = 0; i < deck.Length; i++)
            {
                int swapCardPos = rnd.Next(0, 51);
                Card swap = new Card();

                swap = deck[swapCardPos];
                deck[swapCardPos] = deck[i];
                deck[i] = swap;
            }
        }

        public Player[] DealHand(Player[] players)
        {
            Card[] player1Hand = new Card[13];
            Card[] player2Hand = new Card[13];
            Card[] player3Hand = new Card[13];
            Card[] player4Hand = new Card[13];

            for (int i = 0; i < 13; i++)
            {
                player1Hand[i] = deck[i * 1];
                player2Hand[i] = deck[i * 2];
                player3Hand[i] = deck[i * 3];
                player4Hand[i] = deck[i * 4];
            }

            players[0].newHand(player1Hand);
            players[1].newHand(player2Hand);
            players[2].newHand(player3Hand);
            players[3].newHand(player4Hand);

            return players;
        }
    }
}

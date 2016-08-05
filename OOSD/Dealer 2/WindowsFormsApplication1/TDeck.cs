using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TDeck
    {
        private TCard[] cards;
        private int deckSize;
        private int numPlayers;

        public TDeck()
        {
            deckSize = 52;
            cards = new TCard[deckSize];
            numPlayers = 4;
            int cardCount = 0;

            for (int i = 2; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards[cardCount++] = new TCard(i, j);
                }
            }
        }

        public void DealCards(THand[] handArray)
        {
            int cardIndex = 0;

            for (int i = 0; i < deckSize / numPlayers; i++)
            {
                for (int j = 0; j < numPlayers; j++)
                {
                    handArray[j].addCard(cards[cardIndex]);
                    cardIndex++;
                }
            }
        }

        public void SortHands(THand[] handArray)
        {
            for (int i = 0; i < 4; i++)
            {
                handArray[i].sortHand();
            }
        }

        public string ToString(THand[] handArray)
        {
            String AllHands = "";
            for (int i = 0; i < 4; i++)
            {
                AllHands += "Player " + (i + 1) + ": \r\n";
                AllHands += handArray[i].ToString();
                AllHands += "Points: " + handArray[i].calcPoints() + "\r\n \r\n";
            }

            return AllHands;
        }

        public void ShuffleDeck()
        {
            Random random = new Random();
            TCard temp;
            for (int i = 0; i < 208; i++)
            {
                int index1 = random.Next(0, 51);
                int index2 = random.Next(0, 51);
                temp = cards[index1];
                cards[index1] = cards[index2];
                cards[index2] = temp;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeGame
{
    class Player
    {
        private string playerName;
        private Card[] hand;        
        private int handScore;

        public Player(string playerName)
        {
            this.playerName = playerName;
            handScore = 0;
            hand = new Card[13];
        }
        
        public void newHand(Card[] newHand)
        {
            for (int i = 0; i < newHand.Length; i++)
            {
                hand[i] = newHand[i];
            }
        }

        public int CalculateScore()
        {
            handScore = 0;
            for (int i = 0; i < hand.Length; i++)
            {
                handScore += hand[i].getValue();
            }

            return handScore;
        }

        public String DisplayHand()
        {
            String myHand = "";

            String spades = "S:\t";
            String hearts = "H:\t";
            String diamonds = "D:\t";
            String clubs = "C:\t";

            for (int i = 0; i < 13; i++)
            {

                if (hand[i].getSuit() == "S")
                {
                    spades += hand[i].getNumber();
                }

                if (hand[i].getSuit() == "C")
                {
                    clubs += hand[i].getNumber();
                }

                if (hand[i].getSuit() == "D")
                {
                    diamonds += hand[i].getNumber();
                }

                if (hand[i].getSuit() == "H")
                {
                    hearts += hand[i].getNumber();
                }
            }

            myHand += spades + "\n";
            myHand += hearts + "\n";
            myHand += diamonds + "\n";
            myHand += clubs + "\n";

            return myHand + "\r\n";
        }
    }
}

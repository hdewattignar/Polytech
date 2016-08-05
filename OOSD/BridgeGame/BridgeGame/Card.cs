using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeGame
{
    class Card
    {
        private string suit;
        private string number;
        private int value;

        public Card()
        {
            suit = "";
            number = "";
            value = 0;
        }

        public Card(string suit, string number)
        {
            this.suit = suit;
            this.number = number;
            
            if (number == "J")
                value = 1;
            else if (number == "Q")
                value = 2;
            else if (number == "K")
                value = 3;
            else if (number == "A")
                value = 4;
            else 
                value = 0;
        }

        public string getSuit()
        {
            return suit;
        }

        public String getNumber()
        {
            return number;

        }

        public int getValue()
        {
            return value;
        }

    }
}

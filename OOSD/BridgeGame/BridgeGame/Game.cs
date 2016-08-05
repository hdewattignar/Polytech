using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeGame
{
    class Game
    {
        Player[] players;
        Deck deck;

        public Game()
        {
            players = new Player[4];
            deck = new Deck();

            Player player1 = new Player("North");
            Player player2 = new Player("South");
            Player player3 = new Player("East");
            Player player4 = new Player("West");

            players[0] = player1;
            players[1] = player2;
            players[2] = player3;
            players[3] = player4;
        }

        public void PlayGame()
        {
            deck.Shuffle();
            deck.DealHand(players);
        }
                

        public String DisplayScores()
        {
            String displayScores = "";

            return displayScores;
        }

        public String DisplayHands()
        {
            String displayString = "";

            for (int i = 0; i < players.Length; i++)
            {
                displayString += players[i].DisplayHand();
            }

            return displayString;
        }
    
    }   
}

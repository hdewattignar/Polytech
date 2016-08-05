using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public enum Suits
    {
        spades = 0,
        clubs = 1,
        diamonds = 2,
        hearts = 3
    }

    public enum HighCards
    {
        ace = 14,
        king = 13,
        queen = 12,
        jack = 11
    }

    public enum HandSize
    {
        size = 13
    }

    // Enums wouldn't work in the switch; complained that they weren't cast as int

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TDeck newDeck = new TDeck();
            THand[] fourHands = new THand[4];
            for (int i = 0; i < 4; i++)
            {
                fourHands[i] = new THand();
            }

            newDeck.ShuffleDeck();
            newDeck.DealCards(fourHands);
            newDeck.SortHands(fourHands);
            CardBox.Text = newDeck.ToString(fourHands);
            findWinner(fourHands);
        }

        private void findWinner(THand[] fourHands)
        {
            int maxPoints = 0;
            int maxPos = 0;
            bool tie = false;
            int[] allPoints = new int[4];
            int[] tiePos = new int[4];
            int numTies = 0;
            for (int i = 0; i < 4; i++)
            {
                int thisPoints = fourHands[i].calcPoints();
                allPoints[i] = thisPoints;
                if (thisPoints > maxPoints)
                {
                    maxPos = i;
                    maxPoints = thisPoints;
                    tie = false;
                    numTies = 0;
                }
                else if (thisPoints == maxPoints)
                {
                    tiePos[numTies] = maxPos;
                    tiePos[++numTies] = i;
                    maxPos = i;
                    tie = true;
                }
            }
            if (tie)
            {
                String Winner = "Player " + (tiePos[0] + 1);
                int j;
                for (j = 1; j <= numTies; j++)
                {
                    Winner += ", Player " + (tiePos[j] + 1);
                }
                Winner += " are tied with " + allPoints[tiePos[j]] + " points!";
                WinnerBox.Text = Winner;
            }
            else WinnerBox.Text = "Player " + (maxPos + 1) + " wins with " + maxPoints + " points!";
            Score1.Text = "" + allPoints[0];
            Score2.Text = "" + allPoints[1];
            Score3.Text = "" + allPoints[2];
            Score4.Text = "" + allPoints[3];
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

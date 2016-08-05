using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class TCard
    {
        private int privateNumber;
        private int privateSuit;

        public int number
        {
            get
            {
                return privateNumber;
            }

            set
            {
                privateNumber = value;
            }
        }

        public int suit
        {
            get
            {
                return privateSuit;
            }

            set
            {
                privateSuit = value;
            }
        }

        public TCard (int number, int suit)
        {
            privateNumber = number;
            privateSuit = suit;
        }

        public override string ToString()
        {
            String ThisCard = "";

            switch (privateNumber)
            {
                case 14:
                    ThisCard += "A";
                    break;

                case 11:
                    ThisCard += "J";
                    break;

                case 12:
                    ThisCard += "Q";
                    break;

                case 13:
                    ThisCard += "K";
                    break;

                case 10:
                    ThisCard += "T";
                    break;

                default:
                    ThisCard += privateNumber;
                    break;
            }

            return ThisCard;

            //ThisCard += ": ";

            //switch (privateSuit)
            //{
            //    case 0:
            //        ThisCard += "S";
            //        break;

            //    case 1:
            //        ThisCard += "C";
            //        break;

            //    case 2:
            //        ThisCard += "D";
            //        break;

            //    case 3:
            //        ThisCard += "H";
            //        break;
            //}
            //
        }
    }
}

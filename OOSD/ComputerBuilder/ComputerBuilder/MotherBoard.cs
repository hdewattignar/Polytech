using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    class MotherBoard
    {
        protected string name;
        protected double price;

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public MotherBoard()
        {

        }

        public override String ToString()
        {
            return Convert.ToString(price) + "\t" + name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Lion : Animal
    {
        public Lion()
        {
            name = "Lion";
            family = "Carnivore";
            food = "Zebra";
            image = new Bitmap("lion.jpg");
        }
    }
}

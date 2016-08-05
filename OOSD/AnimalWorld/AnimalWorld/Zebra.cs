using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Zebra : Animal
    {
        public Zebra()
        {
            name = "Zebra";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("zebra.jpg");
        }
    }
}

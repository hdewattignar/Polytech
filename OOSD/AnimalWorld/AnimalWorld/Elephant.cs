using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Elephant : Animal
    {
        public Elephant()
        {
            name = "Elephant";
            family = "Herbivore";
            food = "Leaves";
            image = new Bitmap("elephant.jpg");
        }
    }
}

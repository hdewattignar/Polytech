using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Dear : Animal
    {
        public Dear()
        {
            name = "Dear";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("dear.jpg");
        }
    }
}

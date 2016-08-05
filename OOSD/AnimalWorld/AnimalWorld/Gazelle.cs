using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Gazelle : Animal
    {
        public Gazelle()
        {
            name = "Gazelle";
            family = "Herbivore";
            food = "Grass";
            image = new Bitmap("gazelle.jpg");
        }
    }
}

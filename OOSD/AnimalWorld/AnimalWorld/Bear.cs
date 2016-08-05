using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Bear : Animal
    {
        public Bear()
        {
            name = "Bear";
            family = "Omnivore";
            food = "just about anything";
            image = new Bitmap("bear.jpg");
        }
    }
}

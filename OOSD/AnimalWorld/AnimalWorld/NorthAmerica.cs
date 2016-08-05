using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    class NorthAmerica : Continent
    {
        public NorthAmerica(Random rGen, int nAnimalTypes)
            : base(rGen, nAnimalTypes)
        {
            animalFactory = new NorthAmericanAnimalFactory();
        }
    }
}

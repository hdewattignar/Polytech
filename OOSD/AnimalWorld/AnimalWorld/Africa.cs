using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalWorld
{
    class Africa : Continent
    {
        public Africa(Random rGen, int nAnimalTypes)
            : base(rGen, nAnimalTypes)
        {
            animalFactory = new AfricanAnimalFactory();
        }
    }
}

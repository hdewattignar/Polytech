using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 4;        
        protected Random rGen;
        protected int nAnimalTypes;       
        protected IAnimalFactory animalFactory;

        public Continent(Random rGen, int nAnimalTypes)
        {            
            this.rGen = rGen;
            this.nAnimalTypes = nAnimalTypes;            
        }

        //make a list of animals
        public List<Animal> getAnimalList()
        {
            List<Animal> animals = new List<Animal>();

            for(int i = 0; i < ANIMAL_SIM_COUNT; i++)
            {
                Animal currentAnimal = null;
                int animalChoice = rGen.Next(nAnimalTypes);

                currentAnimal = animalFactory.createAnimal(animalChoice);
                animals.Add(currentAnimal);
            }

            return animals;
        }
    } 
}

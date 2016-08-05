using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    class Manager
    {
        Continent continent;        
        List<PictureBox> pictureBoxes;
        Random rGen;
        ListBox display;

        public Manager(List<PictureBox> pictureBoxes, ListBox display)
        {
            this.pictureBoxes = pictureBoxes;
            rGen = new Random();
            this.display = display;
            continent = null;
        }
        
        public void runSimulation(Continent newContinent)
        {
            //set the new continent
            continent = newContinent;
            // get a list of animals from the continent
            List<Animal> animals = continent.getAnimalList();
            
            //for each animal set a set the picturebox and list box
            for(int i = 0; i < animals.Count; i++)
            {
                pictureBoxes[i].Image = animals[i].Image;
                display.Items.Add(animals[i].ToString());
            }
        }



        
    }
}

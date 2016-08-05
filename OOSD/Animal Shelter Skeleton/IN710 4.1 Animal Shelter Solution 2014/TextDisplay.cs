using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class TextDisplay: IDisplay
    {

        private ListBox listBox;

        public TextDisplay(ListBox listBox)
        {
            this.listBox = listBox;
        }

        //loop through the critter list and add all items to the list box
        public void displayCritterList(List<Critter> critterList)
        {
            for(int i = 0; i < critterList.Count; i++)
            {
                listBox.Items.Add(critterList[i].Name);
            }
        }

        public void clearDisplay()
        {
            listBox.Items.Clear();
        }
    }
}

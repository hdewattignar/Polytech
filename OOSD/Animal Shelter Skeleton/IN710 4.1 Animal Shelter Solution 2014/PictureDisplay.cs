using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace IN710_4._1_Animal_Shelter_Solution_2014
{
    class PictureDisplay: IDisplay
    {
        private List<PictureBox> pictureBoxList;

        public PictureDisplay(List<PictureBox> pictureBoxList)
        {
            this.pictureBoxList = pictureBoxList;
        }

       // loop through the critterList adding all items pictures to the picture boxes
        public void displayCritterList(List<Critter> critterList)
        {
            for(int i = 0; i < critterList.Count; i++)
            {
                pictureBoxList[i].Load(critterList[i].ImageFileName);
            }
        }

        public void clearDisplay()
        {
            for(int i = 0; i < pictureBoxList.Count; i++)
            {
                pictureBoxList[i].BackgroundImage = null;
            }
        }
    }
}

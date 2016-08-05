using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    class Manager
    {
        List<PictureBox> pictureBoxes;
        CharacterMaker maker;
        Character character;

        public Manager(List<PictureBox> pictureBoxes)
        {            
            this.pictureBoxes = pictureBoxes;
            maker = new CharacterMaker();            
        }

        public void Run(int newHead, int newBody, int newFeet)
        {
            character = maker.createCharacter(newHead, newBody, newFeet);
           
            pictureBoxes[0].Image = character.Head.Image;
            pictureBoxes[1].Image = character.Body.Image;
            pictureBoxes[2].Image = character.Feet.Image;
        }
    }
}

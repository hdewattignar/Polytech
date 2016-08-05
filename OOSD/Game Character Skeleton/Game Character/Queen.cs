using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Queen : Character
    {
        public Queen(String name, ListBox listbox)
            : base(name, listbox)
        {
            weapon = new WeaponBow();
        }

        public override void Declaim()
        {
            listbox.Items.Add("I am a powerful Queen!");
        }
       
    }
}

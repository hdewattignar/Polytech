using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class King : Character
    {
        public King(String name, ListBox listbox)
            : base(name, listbox)
        {
            weapon = new WeaponSword();
        }

        public override void Declaim()
        {
            listbox.Items.Add("I am the most mighty of Kings");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    class Troll : Character
    {
        public Troll(String name, ListBox listbox)
            : base(name, listbox)
        {
            weapon = new WeaponKnife();
        }

        public override void Declaim()
        {
            listbox.Items.Add("Trolls dont have time to chat");
        }
    }
}

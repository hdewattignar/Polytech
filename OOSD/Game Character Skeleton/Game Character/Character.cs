using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    abstract class Character
    {

        protected String name;
        protected IWeapon weapon;
        protected ListBox listbox;

        public Character(String name, ListBox listbox)
        {
            this.name = name;
            this.listbox = listbox;
        }

        public virtual String getName()
        {
            return name;
        }

        public virtual void StateName()
        {
            listbox.Items.Add("My name is " + name);
        }

        public virtual void Battle()
        {
            listbox.Items.Add(weapon.UseWeapon());
        }

        public virtual void setWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        abstract public void Declaim();   


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixAndMatch
{
    class Character
    {
        Head head;
        Body body;
        Feet feet;

        public Head Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        public Feet Feet
        {
            get
            {
                return feet;
            }

            set
            {
                feet = value;
            }
        }

        public Body Body
        {
            get
            {
                return body;
            }

            set
            {
                body = value;
            }
        }

        public Character(Head head, Body body, Feet feet)
        {
            this.head = head;
            this.body = body;
            this.feet = feet;
        }
    }
}

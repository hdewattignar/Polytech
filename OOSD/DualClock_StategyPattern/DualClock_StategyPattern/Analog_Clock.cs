using AnalogClockControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualClock_StategyPattern
{
    class Analog_Clock : IClock
    {
        AnalogClock analogClock;        
        
        //constructor. pass in the analog clock conrol from the form
        public Analog_Clock(AnalogClock analogClock)
        {
            this.analogClock = analogClock;
        }

        public void On()
        {
            analogClock.Start();
        }

        public void Off()
        {
            analogClock.Stop();
        }

        //the clock seems to update by itself so just make sure it is visable
        public void UpdateTimeDisplay()
        {
            analogClock.Visible = true;
        }
                
        public void HideClock()
        {
            analogClock.Visible = false;
        }
    }
}

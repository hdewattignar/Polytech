using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualClock_StategyPattern
{
    class Digital_Clock : IClock
    {
        Label digitalClock;
        Timer timer;

        public Digital_Clock(Label digitalClock, Timer timer)
        {
            this.digitalClock = digitalClock;
            this.timer = timer;
        }

        public void On()
        {
            timer.Enabled = true;
        }

        public void Off()
        {
            timer.Enabled = false;
        }

        //display time in appropriate format
        public void UpdateTimeDisplay()
        {
            digitalClock.Visible = true;            

            // mike sure the time has a zero if it below ten for proper formating
            string hour;            
            if (DateTime.Now.Hour < 10)
            {
                hour = "0" + Convert.ToString(DateTime.Now.Hour);
            }
            else
                hour = Convert.ToString(DateTime.Now.Hour);

            string min;
            if (DateTime.Now.Minute < 10)
            {
                min = "0" + Convert.ToString(DateTime.Now.Second);
            }
            else
                min = Convert.ToString(DateTime.Now.Minute);

            string sec;
            if(DateTime.Now.Second < 10)
            {
                sec = "0" + Convert.ToString(DateTime.Now.Second);
            }
            else
                sec = Convert.ToString(DateTime.Now.Second);


            digitalClock.Text = hour + ":" + min + ":" + sec;
        }

        public void HideClock()
        {
            digitalClock.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DualClock_StategyPattern
{
    public partial class Form1 : Form
    {
        IClock clock;

        public Form1()
        {
            InitializeComponent();

            lbl_DigitalClock.Visible = true;
            analogClock.Visible = false;
            analogClock.Enabled = false;
            
        }
        

        private void btn_StartClock_Click(object sender, EventArgs e)
        {
            
            clock.On();
        }

        private void btn_StopClock_Click(object sender, EventArgs e)
        {
            
            clock.Off();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clock.UpdateTimeDisplay();
        }

        private void rb_Digital_CheckedChanged(object sender, EventArgs e)
        {
            clock = new Digital_Clock(lbl_DigitalClock, timer1);
            lbl_DigitalClock.Visible = true;
            analogClock.Visible = false;
            analogClock.Enabled = false;
        }

        private void rb_Analog_CheckedChanged(object sender, EventArgs e)
        {
            analogClock.Visible = true;
            analogClock.Enabled = true;
            clock = new Analog_Clock(analogClock);
        }


    }
}

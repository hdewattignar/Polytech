using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    public partial class Form1 : Form
    {
        RPMSubject subject;
        RPMObserver rpm;
        CalorieCalculatorObserver calorie;
        SpeedObserver speed;

        public Form1()
        {
            InitializeComponent();

            subject = new RPMSubject();
            rpm = new RPMObserver(lb_RPM_Display, subject);
            calorie = new CalorieCalculatorObserver(lb_CaloriesDisplay, subject);
            speed = new SpeedObserver(lb_kmsPerHourDisplay, subject);

        }

        private void btn_ChangeSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                subject.CurrentRPM = Convert.ToInt32(textBox1.Text);
                subject.NotifyObservers();
            }
            catch(FormatException)
            {
                
            }
            
        }
    }
}

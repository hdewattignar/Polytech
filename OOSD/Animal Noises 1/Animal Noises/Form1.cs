using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Animal_Noises
{
    public partial class Form1 : Form
    {
        ThreadStart ts;
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private Animal mainAnimal;

        private void Form1_Load(object sender, EventArgs e)
        {
            mainAnimal = new Animal();            
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            ts = new ThreadStart(mainAnimal.speak);
            t = new Thread(ts);
            t.Start();            
        }

        private void btnWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a frog");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if(t != null)
                t.Abort();
        }

        


    }
}

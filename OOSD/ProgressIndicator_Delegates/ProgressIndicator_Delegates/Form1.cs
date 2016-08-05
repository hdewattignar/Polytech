using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressIndicator_Delegates
{
    public partial class Form1 : Form
    {       
        
        private ProgressControls progresscontrols;

        public Form1()
        {
            InitializeComponent();            
        }

        public void SlowMethod(ProgressControls progress)
        {
            System.Threading.Thread.Sleep(1000);

            
            progress();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (rb_spinBox.Checked == true)
            {
                progresscontrols = new ProgressControls(UpdateSpin);
            }
            else if (rb_ProgressBar.Checked == true)
            {
                progresscontrols = new ProgressControls(UpdateProgressBar);
            }
            else
                progresscontrols = new ProgressControls(UpdateTrackBar);

            for (int i = 0; i < 10; i++ )
            {
                SlowMethod(progresscontrols);

                Application.DoEvents();
            }
        }

        public void UpdateSpin()
        {
            numericUpDown1.Value++;            
        }

        public void UpdateProgressBar()
        {
            progressBar.PerformStep();
        }

        public void UpdateTrackBar()
        {
            trackbar.Value++;
        }                
    }

    public delegate void ProgressControls();
}

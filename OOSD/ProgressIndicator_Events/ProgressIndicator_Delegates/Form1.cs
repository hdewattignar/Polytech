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
        private ProgressSubject slowWorker;

        public Form1()
        {
            InitializeComponent();

            slowWorker = new ProgressSubject();
        }       

        private void btn_start_Click(object sender, EventArgs e)
        {
            slowWorker.SlowMethod();
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
}

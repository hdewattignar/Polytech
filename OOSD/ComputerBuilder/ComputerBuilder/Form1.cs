using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IMachine_Maker currMachineMaker;

        private void btn_PriceSpec_Click(object sender, EventArgs e)
        {
            if (rb_Game.Checked)
                currMachineMaker = new GameMachineMaker();
            else if (rb_Business.Checked)
                currMachineMaker = new BusinessMachineMaker();
            else if (rb_MultiMedia.Checked)
                currMachineMaker = new MultiMediaMachineMaker();
            else
                currMachineMaker = new HighEndGamingMachineMaker();

            MachineSpecPrinter currSpecPrinter = new MachineSpecPrinter(currMachineMaker, lb_DisplayBox);
            currSpecPrinter.printSpec();
        }        
    }
}

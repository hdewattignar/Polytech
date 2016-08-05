using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public partial class Form1 : Form
    {
        public delegate void ClickEventHandler(object sender, EventArgs e);
        public Form1()
        {
            InitializeComponent();

            CustomHandler handler1 = new CustomHandler();

            this.btn_testHandlers.Click += new System.EventHandler(handler1.CustomClickHandler);

            CustomHandler handler2 = new CustomHandler();

            this.btn_testHandlers.Click += new System.EventHandler(handler2.CustomClickHandler);
        }

        private void btn_testHandlers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the forms button handler");
        }
    }
}

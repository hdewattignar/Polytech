using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form1 : Form
    {        
        Manager manager;
        List<PictureBox> pictureBoxes;
        Continent continent;
        Random rGen;

        public Form1()
        {
            InitializeComponent();
            rGen = new Random();
            
            //setup a list of pictureboxes
            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);

            for (int i = 0; i < pictureBoxes.Count; i ++)
                pictureBoxes[i].SizeMode = PictureBoxSizeMode.StretchImage;

            manager = new Manager(pictureBoxes, lb_Display);           

        }

        //each button creates a new continent and calls the managers run simulation
        private void button1_Click(object sender, EventArgs e)
        {
            lb_Display.Items.Clear();
            continent = new NorthAmerica(rGen, 4);
            manager.runSimulation(continent);
        }

        private void btn_Australia_Click(object sender, EventArgs e)
        {
            lb_Display.Items.Clear();
            continent = new Australia(rGen, 4);
            manager.runSimulation(continent);
        }

        private void btn_Africa_Click(object sender, EventArgs e)
        {
            lb_Display.Items.Clear();
            continent = new Africa(rGen, 4);
            manager.runSimulation(continent);
        }
    }
}

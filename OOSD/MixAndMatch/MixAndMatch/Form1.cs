using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class Form1 : Form
    {
        List<PictureBox> pictureBoxes;
        Manager manager;
        public Form1()
        {
            InitializeComponent();

            //populate combo box
            cb_Head.DataSource = Enum.GetValues(typeof(CharacterTypes));
            cb_Body.DataSource = Enum.GetValues(typeof(CharacterTypes));
            cb_Feet.DataSource = Enum.GetValues(typeof(CharacterTypes));
            
            pb_Head.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_Body.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_Feet.SizeMode = PictureBoxSizeMode.AutoSize;

            //add the picture boxes to a list
            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pb_Head);
            pictureBoxes.Add(pb_Body);
            pictureBoxes.Add(pb_Feet);

            //instantiate the manager
            manager = new Manager(pictureBoxes);            
        }

        private void btn_MakeMonster_Click(object sender, EventArgs e)
        {
            //get the selected values from the combo boxes and make a new character            
            manager.Run((int)cb_Head.SelectedValue, (int)cb_Body.SelectedValue, (int)cb_Feet.SelectedValue);            
        }
    }
}

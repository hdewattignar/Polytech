using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predicate
{
    public partial class Form1 : Form
    {
        List<int> randomNumbers;
        Random rnd;
        Predicate<int> predicate;
        public Form1()
        {
            InitializeComponent();

            randomNumbers = new List<int>();
            rnd = new Random();

            GenerateRandoms();
        }

        public void GenerateRandoms()
        {
            for(int i = 0; i < 50; i++)
            {
                randomNumbers.Add(rnd.Next(100));
            }
        }       

        private void btn_GenerateRandoms_Click(object sender, EventArgs e)
        {
            listBox_RandomsDisplay.Items.Clear();

            for (int i = 0; i < randomNumbers.Count; i++)
            {
                listBox_RandomsDisplay.Items.Add(randomNumbers[i]);
            }
        }

        private void btn_EvenNumbers_Click(object sender, EventArgs e)
        {
            listBox_Sorted.Items.Clear();
            predicate = new Predicate<int>((n) => n % 2 == 0);
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                if (predicate(randomNumbers[i]))
                {
                    listBox_Sorted.Items.Add(randomNumbers[i]);
                }
                
            }
        }

        private void btn_LessThanTen_Click(object sender, EventArgs e)
        {
            listBox_Sorted.Items.Clear();
            predicate = new Predicate<int>((n) => n < 10);
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                if (predicate(randomNumbers[i]))
                {
                    listBox_Sorted.Items.Add(randomNumbers[i]);
                }

            }
        }
    }
}

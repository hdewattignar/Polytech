using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lamda_CityDatabase
{
    public partial class Form1 : Form
    {
        List<City> cityDatabase;

        public Form1()
        {
            InitializeComponent();

            dataBaseSetup();            
        }

        private void dataBaseSetup()
        {
            cityDatabase = new List<City>();

            City city1 = new City("Dunedin", "New Zealand", 100000);
            City city2 = new City("Wellington", "New Zealand", 300000);
            City city3 = new City("Auckland", "New Zealand", 100000000);
            City city4 = new City("Sydney", "Australia", 400000000);
            City city5 = new City("Brisbane", "Australia", 200000000);
            City city6 = new City("Melbourne", "Australia", 300000000);

            cityDatabase.Add(city1);
            cityDatabase.Add(city2);
            cityDatabase.Add(city3);
            cityDatabase.Add(city4);
            cityDatabase.Add(city5);
            cityDatabase.Add(city6);
        }

        public void ForEachWithLamda()
        {
            cityDatabase.ForEach((c) => c.Population *= 3);
            cityDatabase.ForEach( c => listBox_Display.Items.Add(c.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = txt_UserInput.Text;

            Func<string, string, bool> searchCities = (c1, c2) => c1.Equals(c2);

            foreach (City c in cityDatabase)
            {
                
                if (searchCities(userInput, c.CountryName))
                {
                    
                    listBox_Display.Items.Add(c.ToString());
                }
            }
        }

        private void btn_SearchForPart2_Click(object sender, EventArgs e)
        {
            ForEachWithLamda();
        }
    }
}

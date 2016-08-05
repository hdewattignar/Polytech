using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_To_External
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_averageIntensity_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var average = (from a in db.tblStrikes
                           select a.strikeIntensity).Average();

            listBox_Display.Items.Add(average);
        }

        private void btn_Largest_Fires_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var top3 = (from t in db.tblFires
                        orderby t.fireArea
                        select t).Take(3);

            foreach(var t in top3)
            {
                string show = "Date: " + t.fireDate + ", Area: " + t.fireArea + ", Latitude: " + t.fireLatitude + ", Longitude: " + t.fireLongitude;

                listBox_Display.Items.Add(show);
            }

            
        }

        private void btn_Pictures_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var pictures = from p in db.tblPictures
                                join s in db.tblStrikes on p.strikeID equals s.strikeID
                                select new
                                {
                                    s.strikeLatitude, s.strikeLongitude, p.pictureFileName
                                };

            foreach (var p in pictures)
            {
                string show = "Latitude: " + p.strikeLatitude + ", Longitude: " + p.strikeLongitude + ", File name: " + p.pictureFileName;

                listBox_Display.Items.Add(show);
            }
        }

        private void btn_FiresByLightning_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var StrikeFires = from s in db.tblStrikes
                              join f in db.tblFires on s.strikeDate equals f.fireDate
                              where s.strikeLatitude == f.fireLatitude
                              && s.strikeLongitude == f.fireLongitude
                              select f;

            foreach (var a in StrikeFires)
            {
                string show = "Date: " + a.fireDate + "Area: " + a.fireArea + ", Latitude: " + a.fireLatitude + ", Longitude: " + a.fireLongitude;

                listBox_Display.Items.Add(show);
            }
        }
    }
}

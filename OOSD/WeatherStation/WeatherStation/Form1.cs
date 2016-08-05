using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1 : Form
    {

        WeatherMeasurements weatherMeasurements;
        CurrentObserver currentObserver;
        AveragesObserver averageObserver;
        ForecastObserver forcastObserver;

        public Form1()
        {
            InitializeComponent();

            weatherMeasurements = new WeatherMeasurements();

            currentObserver = new CurrentObserver(weatherMeasurements);
            averageObserver = new AveragesObserver(weatherMeasurements);
            forcastObserver = new ForecastObserver(weatherMeasurements);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                weatherMeasurements.Measurements.UpdateMeasurements(Convert.ToInt32(txt_Temperature.Text),Convert.ToInt32(txt_Humidity.Text),Convert.ToInt32(txt_Pressure.Text));
                               
            }
            catch(FormatException)
            {
                MessageBox.Show("Enter numbers only");
            }

            weatherMeasurements.NotifyObservers();

            string[] splitCurrent = currentObserver.Display().Split(',');

            foreach(string value in splitCurrent)
            {
                list_currentReadings.Items.Add(value);
            }

            string[] splitAverage = averageObserver.Display().Split(',');

            foreach (string value in splitAverage)
            {
                list_Average.Items.Add(value);
            }
            
            list_Forecast.Items.Add(forcastObserver.Display());
        }
    }
}

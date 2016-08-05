using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class Measurements
    {
        int temperature;

        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        int humidity;

        public int Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        int pressure;

        public int Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }

        public Measurements()
        {
            temperature = 0;
            humidity = 0;
            pressure = 0;
        }

        public void UpdateMeasurements(int temperature, int humidity, int pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }        
    }
}

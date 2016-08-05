using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class WeatherObserver : IWeatherObserver
    {
        protected Measurements measurements;

        public WeatherObserver(IWeatherSubject weatherSubject)
        {
            measurements = new Measurements();
            weatherSubject.AddObserver(this);
        }

        public virtual void Update(object o)
        {
            measurements = (Measurements)o;
        }

        public virtual String Display()
        {
            String displayString = "";
            String TemperatureString = "Temperature:\t" + Convert.ToString(measurements.Temperature);
            String HumidityString = ",Humidity:\t\t" + Convert.ToString(measurements.Humidity);
            String PressureString = ",Pressure:\t\t" + Convert.ToString(measurements.Pressure);

            displayString = TemperatureString + HumidityString + PressureString;
            return displayString;
        }       
    }
}

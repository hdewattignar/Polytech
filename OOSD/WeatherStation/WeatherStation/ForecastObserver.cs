using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class ForecastObserver : WeatherObserver
    {
        public ForecastObserver(WeatherSubject weatherSubject)
            : base(weatherSubject)
        {

        }

        public override String Display()
        {
            String displayString = "";

            if (measurements.Temperature < 20)
            {
                displayString += "Cool temperatures, ";
            }
            else
                displayString += "Warm temperatures, ";

            if (measurements.Humidity < 80)
                displayString += "low humidity, ";
            else
                displayString += "high humidity, ";

            if (measurements.Pressure < 1000)
                displayString += "low pressure.";
            else
                displayString += "high pressure.";

            return displayString;
        }
    }
}

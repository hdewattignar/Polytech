using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class AveragesObserver : WeatherObserver
    {
        private List<Measurements> measureList;
        public AveragesObserver(WeatherSubject weatherSubject)
            : base(weatherSubject)
        {
            measureList = new List<Measurements>();
        }

        public override void Update(object o)
        {
            Measurements current = (Measurements) o;
            Measurements newMeasurement = new Measurements();
            newMeasurement.UpdateMeasurements(current.Temperature, current.Humidity, current.Pressure);
            measureList.Add(newMeasurement);

            int averageTemperature = 0;
            int averageHumidity = 0;
            int averagePressure = 0;

            for(int i = 0; i < measureList.Count; i++)
            {
                averageTemperature += measureList[i].Temperature;
                averageHumidity += measureList[i].Humidity;
                averagePressure += measureList[i].Pressure;
            }

            averageTemperature = averageTemperature / measureList.Count;
            averageHumidity = averageHumidity / measureList.Count;
            averagePressure = averagePressure / measureList.Count;

            measurements.UpdateMeasurements(averageTemperature, averageHumidity, averagePressure);
        }        
    }
}

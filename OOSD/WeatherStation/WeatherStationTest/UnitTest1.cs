using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStation;

namespace WeatherStationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CurrentTemperatureDisplay()
        {
            WeatherMeasurements subject = new WeatherMeasurements();
            CurrentObserver observer = new CurrentObserver(subject);

            String expected = "Temperature:\t0,Humidity:\t\t0,Pressure:\t\t0";
            String actual = observer.Display();

            subject.NotifyObservers();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AverageTemperatureDisplay()
        {
            WeatherMeasurements subject = new WeatherMeasurements();
            AveragesObserver observer = new AveragesObserver(subject);

            subject.Measurements.UpdateMeasurements(5, 5, 5);
            subject.NotifyObservers();
            subject.Measurements.UpdateMeasurements(7, 7, 7);
            subject.NotifyObservers();

            String expected = "Temperature:\t6,Humidity:\t\t6,Pressure:\t\t6";
            String actual = observer.Display();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ForcastDisplay()
        {
            WeatherMeasurements subject = new WeatherMeasurements();
            ForecastObserver observer = new ForecastObserver(subject);

            subject.Measurements.UpdateMeasurements(30, 85, 992);
            subject.NotifyObservers();

            String expected = "Warm temperatures, high humidity, low pressure.";
            String actual = observer.Display();

            subject.NotifyObservers();

            Assert.AreEqual(expected, actual);
        }      
    }
}

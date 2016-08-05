using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class WeatherSubject : IWeatherSubject
    {
        protected Measurements measurements;

        public Measurements Measurements
        {
            get { return measurements; }
            set { measurements = value; }
        }
        protected List<IWeatherObserver> observerlist;

        public WeatherSubject()
        {
            measurements = new Measurements();
            observerlist = new List<IWeatherObserver>();
        }

        public void AddObserver(IWeatherObserver newObserver)
        {
            observerlist.Add(newObserver);
        }

        public void RemoveObserver(IWeatherObserver newObserver)
        {
            observerlist.Remove(newObserver);
        }

        public void NotifyObservers()
        {
            foreach (IWeatherObserver currentObserver in observerlist)
                currentObserver.Update(measurements);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IWeatherSubject
    {
        void AddObserver(IWeatherObserver newObserver);
        void RemoveObserver(IWeatherObserver newObserver);
        void NotifyObservers();
    }
}

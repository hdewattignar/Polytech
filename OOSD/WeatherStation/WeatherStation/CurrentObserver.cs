using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class CurrentObserver : WeatherObserver
    {
        public CurrentObserver(WeatherSubject weatherSubject)
            : base(weatherSubject)
        {

        }       
    }
}

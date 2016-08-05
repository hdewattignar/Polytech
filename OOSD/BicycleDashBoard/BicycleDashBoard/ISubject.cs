using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashBoard
{
    public interface ISubject
    {
        void AddObserver(IObserver newObserver);
        void RemoveObserver(IObserver newObserver);
        void NotifyObservers();
    }
}

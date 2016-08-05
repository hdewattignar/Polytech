using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashBoard
{
    public abstract class BicycleSubject : ISubject
    {
        protected int currentRPM;
        public int CurrentRPM
        {
            get
            {
                return currentRPM;
            }

            set
            {
                currentRPM = value;
            }
        }


        protected List<IObserver> observerlist;

        public BicycleSubject()
        {
            currentRPM = 0;
            observerlist = new List<IObserver>();
        }

        public void AddObserver(IObserver newObserver)
        {
            observerlist.Add(newObserver);
        }

        public void RemoveObserver(IObserver newObserver)
        {
            observerlist.Remove(newObserver);
        }

        public void NotifyObservers()
        {
            foreach (IObserver currentObserver in observerlist)
                currentObserver.Update(currentRPM);
        }
    }
}

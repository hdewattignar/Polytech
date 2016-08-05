using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleDashBoard
{
    public abstract class BicycleObserver : IObserver
    {
        protected int RPM;
        protected double currentValue;
        protected Label displayLabel;
        protected ISubject bicycleSubject;

        public BicycleObserver(Label displayLabel, ISubject bicycleSubject)
        {
            this.displayLabel = displayLabel;

            RPM = 0;
            currentValue = 0;

            bicycleSubject.AddObserver(this);
        }

        public abstract void Update(int data);       

        public void Display()
        {
            displayLabel.Text = Convert.ToString(currentValue);
        }
}
}

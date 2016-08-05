using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleDashBoard
{
    public interface IObserver
    {
        void Update(int data);
        void Display();
    }
}

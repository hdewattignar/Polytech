using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkMessager
{
    public interface IMessageSubject
    {
        void AddObserver(IMessageObserver newObserver);
        void RemoveObserver(IMessageObserver newObserver);
        void NotifyObservers();
    }
}

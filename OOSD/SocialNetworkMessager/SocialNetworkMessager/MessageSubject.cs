using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkMessager
{
    public class MessageSubject : IMessageSubject
    {
        private Status message;

        public Status Message
        {
            get { return message; }
            set { message = value; }
        }

        private List<IMessageObserver> observerList;
        public MessageSubject()            
        {
            message = null;
            observerList = new List<IMessageObserver>();
        }

        public void AddObserver(IMessageObserver newObserver)
        {
            observerList.Add(newObserver);
        }

        public void RemoveObserver(IMessageObserver newObserver)
        {
            observerList.Remove(newObserver);
        }

        public void NotifyObservers()
        {
            foreach (IMessageObserver currentObserver in observerList)
                currentObserver.Update(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkMessager
{
    public class MessageObserver : IMessageObserver
    {
        private Status message;

        public MessageObserver(IMessageSubject subject)
        {
            message = null;
            subject.AddObserver(this);
        }

        public void Update(Status newStatus)
        {
            message = newStatus;
        }

        public string Display()
        {
            //build display string
            String displayString = "";
            
            //format the Date
            String displayTime = message.TimeOfMessage.ToUniversalTime().ToString("r");
            displayString = displayTime + "\n" + message.Message;

            return displayString;
        }
    }
}

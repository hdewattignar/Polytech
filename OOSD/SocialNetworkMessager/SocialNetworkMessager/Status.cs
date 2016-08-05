using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetworkMessager
{
    public class Status
    {
        private DateTime timeOfMessage;

        public DateTime TimeOfMessage
        {
            get { return timeOfMessage; }
            set { timeOfMessage = value; }
        }
        private String message;

        public String Message
        {
            get { return message; }
            set { message = value; }
        }

        public Status(DateTime newTime, String newMessage)
        {
            timeOfMessage = newTime;
            message = newMessage;
        }
    }
}

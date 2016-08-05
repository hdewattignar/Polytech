using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public abstract class FireAlarmObserver
    {
        protected FireAlarmSubject subject;

        public FireAlarmObserver(FireAlarmSubject subject)
        {
            this.subject = subject;

            FireAlarmSubject.FireEventHandler handler = new FireAlarmSubject.FireEventHandler(HandlerMethod);

            subject.FireEvent += handler;
        }

        public abstract void HandlerMethod(object fireObject, FireAlarmEventArgs fe);
    }
}

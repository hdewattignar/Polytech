using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{    
    public class FireAlarmSubject
    {
        public delegate void FireEventHandler(object fireSubject, FireAlarmEventArgs fireEventArgs);
        public event FireEventHandler FireEvent;
        
        public void OnFireEvent(EFireCategory fireCategory)
        {
            FireAlarmEventArgs fe = new FireAlarmEventArgs(fireCategory);

            if (FireEvent != null)
                FireEvent(this, fe);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FireAlarm
{
    public class FireToneObserver : FireAlarmObserver
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
        public FireToneObserver(FireAlarmSubject subject)
            :base(subject)
        {

        }

        public override void HandlerMethod(object fireObject, FireAlarmEventArgs fe)
        {
            switch (fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    Beep(200,1000);
                    break;
                case EFireCategory.SERIOUS:
                    Beep(400, 1000);
                    break;
                case EFireCategory.INFERNO:
                    Beep(600, 1000);
                    break;
            }
        }
    }
}

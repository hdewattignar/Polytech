using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public class FireInstructionsObserver : FireAlarmObserver
    {
        public FireInstructionsObserver(FireAlarmSubject subject)
            :base(subject)
        {

        }

        public override void HandlerMethod(object fireObject, FireAlarmEventArgs fe)
        {
            String message = "Fire is " + fe.FireCategory.ToString() + ",";

            switch(fe.FireCategory)
            {
                case EFireCategory.MINOR:
                    message += " use a fire extinguster.";
                    break;
                case EFireCategory.SERIOUS:
                    message += " call the Fire Fepartment.";
                    break;
                case EFireCategory.INFERNO:
                    message += "Evacuate Immediately.";
                    break;                
            }

            MessageBox.Show(message);
        }
    }
}

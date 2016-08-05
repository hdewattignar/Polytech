using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressIndicator_Delegates
{
    public class ProgressSubject
    {
        public ProgressSubject()
        {

        }

        public void SlowMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(500);
                OnUpdateEvent();
            }
        }

        private void OnUpdateEvent()
        {
            throw new NotImplementedException();
        }
    }
}

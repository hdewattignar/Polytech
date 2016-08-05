using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlHandler
{
    public class CustomHandler
    {
        protected int code;
        protected Random rnd;

        public CustomHandler()
        {
            rnd = new Random();
            code = rnd.Next(50);

        }

        public void CustomClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("This is a custom handler.\nMycode number is " + code);
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    public partial class Form1 : Form
    {
        private FireAlarmSubject subject;
        private FireAlarmObserver instructionObserver;
        private FireToneObserver toneObserver;

        public Form1()
        {
            InitializeComponent();
            subject = new FireAlarmSubject();
            instructionObserver = new FireInstructionsObserver(subject);
            toneObserver = new FireToneObserver(subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb_minor.Checked == true)
                subject.OnFireEvent(EFireCategory.MINOR);
            else if (rb_serious.Checked == true)
                subject.OnFireEvent(EFireCategory.SERIOUS);
            else
                subject.OnFireEvent(EFireCategory.INFERNO);
        }
    }
}

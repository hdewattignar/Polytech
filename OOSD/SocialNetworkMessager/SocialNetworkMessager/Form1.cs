using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialNetworkMessager
{
    public partial class Form1 : Form
    {
        MessageSubject subject;
        MessageObserver main;
        MessageObserver friend1;
        MessageObserver friend2;
        MessageObserver friend3;
        MessageObserver friend4;

        public Form1()
        {
            InitializeComponent();

            subject = new MessageSubject();             
            friend1 = new MessageObserver(subject);
            friend2 = new MessageObserver(subject);
            friend3 = new MessageObserver(subject);
            friend4 = new MessageObserver(subject);
        }

        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            //get text from textBox, make a new Status to give to the subject and update the observers
            String newMessage = txt_Status.Text;
            subject.Message = new Status(DateTime.Now, newMessage);
            subject.NotifyObservers();
            
            //populate the list boxes
            list_Main.Items.Add(newMessage);


            //for each observer split the string in the new line
            string[] splitFriend1 = friend1.Display().Split('\n');

            foreach (string value in splitFriend1)
            {
                list_Friend1.Items.Add(value);
            }

            string[] splitFriend2 = friend2.Display().Split('\n');

            foreach (string value in splitFriend2)
            {
                list_Friend2.Items.Add(value);
            }

            string[] splitFriend3 = friend3.Display().Split('\n');

            foreach (string value in splitFriend3)
            {
                list_Friend3.Items.Add(value);
            }

            string[] splitFriend4 = friend4.Display().Split('\n');

            foreach (string value in splitFriend4)
            {
                list_Friend4.Items.Add(value);
            }

        }
    }
}

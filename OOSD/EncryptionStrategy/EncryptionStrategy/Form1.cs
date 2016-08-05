using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionStrategy
{
    public partial class Form1 : Form
    {

        IEncryption encryptionType;
        public Form1()
        {
            InitializeComponent();

            getEncrytionType();
        }

        public void getEncrytionType()
        {
            if (rb_ROT13.Checked == true)
            {
                encryptionType = new ROT13();
            }
            else if (rb_StringReverse.Checked == true)
            {
                encryptionType = new StringReverse();
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            getEncrytionType();
            txt_Output.AppendText(encryptionType.Encrypt(txt_Input.Text));
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            txt_Output.Clear();
            getEncrytionType();
            txt_Output.AppendText(encryptionType.Decrypt(txt_Input.Text));
        }
    }
}

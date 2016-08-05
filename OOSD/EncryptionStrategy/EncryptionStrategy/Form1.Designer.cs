namespace EncryptionStrategy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_encryptionAlgorithm = new System.Windows.Forms.GroupBox();
            this.rb_ROT13 = new System.Windows.Forms.RadioButton();
            this.rb_StringReverse = new System.Windows.Forms.RadioButton();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.gb_encryptionAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_encryptionAlgorithm
            // 
            this.gb_encryptionAlgorithm.Controls.Add(this.rb_StringReverse);
            this.gb_encryptionAlgorithm.Controls.Add(this.rb_ROT13);
            this.gb_encryptionAlgorithm.Location = new System.Drawing.Point(52, 40);
            this.gb_encryptionAlgorithm.Name = "gb_encryptionAlgorithm";
            this.gb_encryptionAlgorithm.Size = new System.Drawing.Size(200, 117);
            this.gb_encryptionAlgorithm.TabIndex = 0;
            this.gb_encryptionAlgorithm.TabStop = false;
            this.gb_encryptionAlgorithm.Text = "Encryption Algorithm";
            // 
            // rb_ROT13
            // 
            this.rb_ROT13.AutoSize = true;
            this.rb_ROT13.Location = new System.Drawing.Point(7, 35);
            this.rb_ROT13.Name = "rb_ROT13";
            this.rb_ROT13.Size = new System.Drawing.Size(60, 17);
            this.rb_ROT13.TabIndex = 0;
            this.rb_ROT13.TabStop = true;
            this.rb_ROT13.Text = "ROT13";
            this.rb_ROT13.UseVisualStyleBackColor = true;
            // 
            // rb_StringReverse
            // 
            this.rb_StringReverse.AutoSize = true;
            this.rb_StringReverse.Location = new System.Drawing.Point(7, 73);
            this.rb_StringReverse.Name = "rb_StringReverse";
            this.rb_StringReverse.Size = new System.Drawing.Size(95, 17);
            this.rb_StringReverse.TabIndex = 1;
            this.rb_StringReverse.TabStop = true;
            this.rb_StringReverse.Text = "String Reverse";
            this.rb_StringReverse.UseVisualStyleBackColor = true;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(355, 40);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(109, 35);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(511, 40);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(106, 35);
            this.btn_Decrypt.TabIndex = 2;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Location = new System.Drawing.Point(52, 226);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(31, 13);
            this.lbl_Input.TabIndex = 3;
            this.lbl_Input.Text = "Input";
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(52, 298);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(39, 13);
            this.lbl_Output.TabIndex = 4;
            this.lbl_Output.Text = "Output";
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(174, 226);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(443, 20);
            this.txt_Input.TabIndex = 5;
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(174, 298);
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ReadOnly = true;
            this.txt_Output.Size = new System.Drawing.Size(443, 20);
            this.txt_Output.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 385);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.gb_encryptionAlgorithm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_encryptionAlgorithm.ResumeLayout(false);
            this.gb_encryptionAlgorithm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_encryptionAlgorithm;
        private System.Windows.Forms.RadioButton rb_StringReverse;
        private System.Windows.Forms.RadioButton rb_ROT13;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.TextBox txt_Output;
    }
}


namespace FireAlarm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_inferno = new System.Windows.Forms.RadioButton();
            this.rb_serious = new System.Windows.Forms.RadioButton();
            this.rb_minor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fire Alarm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_inferno);
            this.groupBox1.Controls.Add(this.rb_serious);
            this.groupBox1.Controls.Add(this.rb_minor);
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fire Category";
            // 
            // rb_inferno
            // 
            this.rb_inferno.AutoSize = true;
            this.rb_inferno.Location = new System.Drawing.Point(7, 160);
            this.rb_inferno.Name = "rb_inferno";
            this.rb_inferno.Size = new System.Drawing.Size(58, 17);
            this.rb_inferno.TabIndex = 2;
            this.rb_inferno.Text = "Inferno";
            this.rb_inferno.UseVisualStyleBackColor = true;
            // 
            // rb_serious
            // 
            this.rb_serious.AutoSize = true;
            this.rb_serious.Location = new System.Drawing.Point(7, 97);
            this.rb_serious.Name = "rb_serious";
            this.rb_serious.Size = new System.Drawing.Size(60, 17);
            this.rb_serious.TabIndex = 1;
            this.rb_serious.Text = "Serious";
            this.rb_serious.UseVisualStyleBackColor = true;
            // 
            // rb_minor
            // 
            this.rb_minor.AutoSize = true;
            this.rb_minor.Checked = true;
            this.rb_minor.Location = new System.Drawing.Point(7, 41);
            this.rb_minor.Name = "rb_minor";
            this.rb_minor.Size = new System.Drawing.Size(51, 17);
            this.rb_minor.TabIndex = 0;
            this.rb_minor.TabStop = true;
            this.rb_minor.Text = "Minor";
            this.rb_minor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_inferno;
        private System.Windows.Forms.RadioButton rb_serious;
        private System.Windows.Forms.RadioButton rb_minor;
    }
}


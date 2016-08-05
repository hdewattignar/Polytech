namespace DualClock_StategyPattern
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
            this.components = new System.ComponentModel.Container();
            this.btn_StartClock = new System.Windows.Forms.Button();
            this.btn_StopClock = new System.Windows.Forms.Button();
            this.gb_ClockSelect = new System.Windows.Forms.GroupBox();
            this.lbl_DigitalClock = new System.Windows.Forms.Label();
            this.rb_Digital = new System.Windows.Forms.RadioButton();
            this.rb_Analog = new System.Windows.Forms.RadioButton();
            this.analogClock = new AnalogClockControl.AnalogClock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_ClockSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_StartClock
            // 
            this.btn_StartClock.Location = new System.Drawing.Point(43, 30);
            this.btn_StartClock.Name = "btn_StartClock";
            this.btn_StartClock.Size = new System.Drawing.Size(205, 67);
            this.btn_StartClock.TabIndex = 0;
            this.btn_StartClock.Text = "Start Clock";
            this.btn_StartClock.UseVisualStyleBackColor = true;
            this.btn_StartClock.Click += new System.EventHandler(this.btn_StartClock_Click);
            // 
            // btn_StopClock
            // 
            this.btn_StopClock.Location = new System.Drawing.Point(43, 124);
            this.btn_StopClock.Name = "btn_StopClock";
            this.btn_StopClock.Size = new System.Drawing.Size(205, 67);
            this.btn_StopClock.TabIndex = 1;
            this.btn_StopClock.Text = "Stop Clock";
            this.btn_StopClock.UseVisualStyleBackColor = true;
            this.btn_StopClock.Click += new System.EventHandler(this.btn_StopClock_Click);
            // 
            // gb_ClockSelect
            // 
            this.gb_ClockSelect.Controls.Add(this.rb_Analog);
            this.gb_ClockSelect.Controls.Add(this.rb_Digital);
            this.gb_ClockSelect.Location = new System.Drawing.Point(268, 30);
            this.gb_ClockSelect.Name = "gb_ClockSelect";
            this.gb_ClockSelect.Size = new System.Drawing.Size(200, 161);
            this.gb_ClockSelect.TabIndex = 2;
            this.gb_ClockSelect.TabStop = false;
            // 
            // lbl_DigitalClock
            // 
            this.lbl_DigitalClock.AutoSize = true;
            this.lbl_DigitalClock.Enabled = false;
            this.lbl_DigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DigitalClock.Location = new System.Drawing.Point(43, 298);
            this.lbl_DigitalClock.Name = "lbl_DigitalClock";
            this.lbl_DigitalClock.Size = new System.Drawing.Size(425, 108);
            this.lbl_DigitalClock.TabIndex = 3;
            this.lbl_DigitalClock.Text = "00:00:00";
            // 
            // rb_Digital
            // 
            this.rb_Digital.AutoSize = true;
            this.rb_Digital.Location = new System.Drawing.Point(29, 49);
            this.rb_Digital.Name = "rb_Digital";
            this.rb_Digital.Size = new System.Drawing.Size(54, 17);
            this.rb_Digital.TabIndex = 0;
            this.rb_Digital.TabStop = true;
            this.rb_Digital.Text = "Digital";
            this.rb_Digital.UseVisualStyleBackColor = true;
            this.rb_Digital.CheckedChanged += new System.EventHandler(this.rb_Digital_CheckedChanged);
            // 
            // rb_Analog
            // 
            this.rb_Analog.AutoSize = true;
            this.rb_Analog.Location = new System.Drawing.Point(29, 94);
            this.rb_Analog.Name = "rb_Analog";
            this.rb_Analog.Size = new System.Drawing.Size(58, 17);
            this.rb_Analog.TabIndex = 1;
            this.rb_Analog.TabStop = true;
            this.rb_Analog.Text = "Analog";
            this.rb_Analog.UseVisualStyleBackColor = true;
            this.rb_Analog.CheckedChanged += new System.EventHandler(this.rb_Analog_CheckedChanged);
            // 
            // analogClock
            // 
            this.analogClock.Draw1MinuteTicks = true;
            this.analogClock.Draw5MinuteTicks = true;
            this.analogClock.Enabled = false;
            this.analogClock.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock.Location = new System.Drawing.Point(61, 197);
            this.analogClock.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock.Name = "analogClock";
            this.analogClock.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock.Size = new System.Drawing.Size(399, 399);
            this.analogClock.TabIndex = 4;
            this.analogClock.TicksColor = System.Drawing.Color.Black;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 655);
            this.Controls.Add(this.analogClock);
            this.Controls.Add(this.lbl_DigitalClock);
            this.Controls.Add(this.gb_ClockSelect);
            this.Controls.Add(this.btn_StopClock);
            this.Controls.Add(this.btn_StartClock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_ClockSelect.ResumeLayout(false);
            this.gb_ClockSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartClock;
        private System.Windows.Forms.Button btn_StopClock;
        private System.Windows.Forms.GroupBox gb_ClockSelect;
        private System.Windows.Forms.RadioButton rb_Analog;
        private System.Windows.Forms.RadioButton rb_Digital;
        private System.Windows.Forms.Label lbl_DigitalClock;
        private AnalogClockControl.AnalogClock analogClock;
        private System.Windows.Forms.Timer timer1;
    }
}


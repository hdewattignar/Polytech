namespace BicycleDashBoard
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
            this.btn_ChangeSpeed = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_RPM_Display = new System.Windows.Forms.Label();
            this.gb_RPM = new System.Windows.Forms.GroupBox();
            this.gb_Calories = new System.Windows.Forms.GroupBox();
            this.lb_CaloriesDisplay = new System.Windows.Forms.Label();
            this.gb_kmsPerHour = new System.Windows.Forms.GroupBox();
            this.lb_kmsPerHourDisplay = new System.Windows.Forms.Label();
            this.gb_RPM.SuspendLayout();
            this.gb_Calories.SuspendLayout();
            this.gb_kmsPerHour.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChangeSpeed
            // 
            this.btn_ChangeSpeed.Location = new System.Drawing.Point(13, 13);
            this.btn_ChangeSpeed.Name = "btn_ChangeSpeed";
            this.btn_ChangeSpeed.Size = new System.Drawing.Size(105, 84);
            this.btn_ChangeSpeed.TabIndex = 0;
            this.btn_ChangeSpeed.Text = "Change Speed";
            this.btn_ChangeSpeed.UseVisualStyleBackColor = true;
            this.btn_ChangeSpeed.Click += new System.EventHandler(this.btn_ChangeSpeed_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lb_RPM_Display
            // 
            this.lb_RPM_Display.AutoSize = true;
            this.lb_RPM_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RPM_Display.Location = new System.Drawing.Point(157, 38);
            this.lb_RPM_Display.Name = "lb_RPM_Display";
            this.lb_RPM_Display.Size = new System.Drawing.Size(145, 55);
            this.lb_RPM_Display.TabIndex = 3;
            this.lb_RPM_Display.Text = "00.00";
            // 
            // gb_RPM
            // 
            this.gb_RPM.Controls.Add(this.lb_RPM_Display);
            this.gb_RPM.Location = new System.Drawing.Point(13, 130);
            this.gb_RPM.Name = "gb_RPM";
            this.gb_RPM.Size = new System.Drawing.Size(323, 127);
            this.gb_RPM.TabIndex = 4;
            this.gb_RPM.TabStop = false;
            this.gb_RPM.Text = "RPM";
            // 
            // gb_Calories
            // 
            this.gb_Calories.Controls.Add(this.lb_CaloriesDisplay);
            this.gb_Calories.Location = new System.Drawing.Point(12, 263);
            this.gb_Calories.Name = "gb_Calories";
            this.gb_Calories.Size = new System.Drawing.Size(323, 127);
            this.gb_Calories.TabIndex = 5;
            this.gb_Calories.TabStop = false;
            this.gb_Calories.Text = "Calories Per Hour";
            // 
            // lb_CaloriesDisplay
            // 
            this.lb_CaloriesDisplay.AutoSize = true;
            this.lb_CaloriesDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CaloriesDisplay.Location = new System.Drawing.Point(157, 38);
            this.lb_CaloriesDisplay.Name = "lb_CaloriesDisplay";
            this.lb_CaloriesDisplay.Size = new System.Drawing.Size(145, 55);
            this.lb_CaloriesDisplay.TabIndex = 3;
            this.lb_CaloriesDisplay.Text = "00.00";
            // 
            // gb_kmsPerHour
            // 
            this.gb_kmsPerHour.Controls.Add(this.lb_kmsPerHourDisplay);
            this.gb_kmsPerHour.Location = new System.Drawing.Point(13, 396);
            this.gb_kmsPerHour.Name = "gb_kmsPerHour";
            this.gb_kmsPerHour.Size = new System.Drawing.Size(323, 127);
            this.gb_kmsPerHour.TabIndex = 6;
            this.gb_kmsPerHour.TabStop = false;
            this.gb_kmsPerHour.Text = "Kms Per Hour";
            // 
            // lb_kmsPerHourDisplay
            // 
            this.lb_kmsPerHourDisplay.AutoSize = true;
            this.lb_kmsPerHourDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kmsPerHourDisplay.Location = new System.Drawing.Point(157, 38);
            this.lb_kmsPerHourDisplay.Name = "lb_kmsPerHourDisplay";
            this.lb_kmsPerHourDisplay.Size = new System.Drawing.Size(145, 55);
            this.lb_kmsPerHourDisplay.TabIndex = 3;
            this.lb_kmsPerHourDisplay.Text = "00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 545);
            this.Controls.Add(this.gb_kmsPerHour);
            this.Controls.Add(this.gb_Calories);
            this.Controls.Add(this.gb_RPM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ChangeSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_RPM.ResumeLayout(false);
            this.gb_RPM.PerformLayout();
            this.gb_Calories.ResumeLayout(false);
            this.gb_Calories.PerformLayout();
            this.gb_kmsPerHour.ResumeLayout(false);
            this.gb_kmsPerHour.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChangeSpeed;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_RPM_Display;
        private System.Windows.Forms.GroupBox gb_RPM;
        private System.Windows.Forms.GroupBox gb_Calories;
        private System.Windows.Forms.Label lb_CaloriesDisplay;
        private System.Windows.Forms.GroupBox gb_kmsPerHour;
        private System.Windows.Forms.Label lb_kmsPerHourDisplay;
    }
}


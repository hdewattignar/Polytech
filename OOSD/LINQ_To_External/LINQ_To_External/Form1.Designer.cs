namespace LINQ_To_External
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
            this.btn_averageIntensity = new System.Windows.Forms.Button();
            this.btn_Largest_Fires = new System.Windows.Forms.Button();
            this.btn_Pictures = new System.Windows.Forms.Button();
            this.btn_FiresByLightning = new System.Windows.Forms.Button();
            this.listBox_Display = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_averageIntensity
            // 
            this.btn_averageIntensity.Location = new System.Drawing.Point(13, 28);
            this.btn_averageIntensity.Name = "btn_averageIntensity";
            this.btn_averageIntensity.Size = new System.Drawing.Size(190, 23);
            this.btn_averageIntensity.TabIndex = 0;
            this.btn_averageIntensity.Text = "Average Intensity";
            this.btn_averageIntensity.UseVisualStyleBackColor = true;
            this.btn_averageIntensity.Click += new System.EventHandler(this.btn_averageIntensity_Click);
            // 
            // btn_Largest_Fires
            // 
            this.btn_Largest_Fires.Location = new System.Drawing.Point(13, 58);
            this.btn_Largest_Fires.Name = "btn_Largest_Fires";
            this.btn_Largest_Fires.Size = new System.Drawing.Size(190, 23);
            this.btn_Largest_Fires.TabIndex = 1;
            this.btn_Largest_Fires.Text = "Largest Three Fires";
            this.btn_Largest_Fires.UseVisualStyleBackColor = true;
            this.btn_Largest_Fires.Click += new System.EventHandler(this.btn_Largest_Fires_Click);
            // 
            // btn_Pictures
            // 
            this.btn_Pictures.Location = new System.Drawing.Point(13, 88);
            this.btn_Pictures.Name = "btn_Pictures";
            this.btn_Pictures.Size = new System.Drawing.Size(190, 23);
            this.btn_Pictures.TabIndex = 2;
            this.btn_Pictures.Text = "Picture Information";
            this.btn_Pictures.UseVisualStyleBackColor = true;
            this.btn_Pictures.Click += new System.EventHandler(this.btn_Pictures_Click);
            // 
            // btn_FiresByLightning
            // 
            this.btn_FiresByLightning.Location = new System.Drawing.Point(13, 118);
            this.btn_FiresByLightning.Name = "btn_FiresByLightning";
            this.btn_FiresByLightning.Size = new System.Drawing.Size(190, 23);
            this.btn_FiresByLightning.TabIndex = 3;
            this.btn_FiresByLightning.Text = "Fires Caused By Lightning";
            this.btn_FiresByLightning.UseVisualStyleBackColor = true;
            this.btn_FiresByLightning.Click += new System.EventHandler(this.btn_FiresByLightning_Click);
            // 
            // listBox_Display
            // 
            this.listBox_Display.FormattingEnabled = true;
            this.listBox_Display.Location = new System.Drawing.Point(244, 28);
            this.listBox_Display.Name = "listBox_Display";
            this.listBox_Display.Size = new System.Drawing.Size(691, 368);
            this.listBox_Display.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 413);
            this.Controls.Add(this.listBox_Display);
            this.Controls.Add(this.btn_FiresByLightning);
            this.Controls.Add(this.btn_Pictures);
            this.Controls.Add(this.btn_Largest_Fires);
            this.Controls.Add(this.btn_averageIntensity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_averageIntensity;
        private System.Windows.Forms.Button btn_Largest_Fires;
        private System.Windows.Forms.Button btn_Pictures;
        private System.Windows.Forms.Button btn_FiresByLightning;
        private System.Windows.Forms.ListBox listBox_Display;
    }
}


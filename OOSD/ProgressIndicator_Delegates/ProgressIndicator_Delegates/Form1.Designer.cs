namespace ProgressIndicator_Delegates
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
            this.btn_start = new System.Windows.Forms.Button();
            this.gb_feedback = new System.Windows.Forms.GroupBox();
            this.rb_TrackBar = new System.Windows.Forms.RadioButton();
            this.rb_ProgressBar = new System.Windows.Forms.RadioButton();
            this.rb_spinBox = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackbar = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gb_feedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(13, 60);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // gb_feedback
            // 
            this.gb_feedback.Controls.Add(this.rb_TrackBar);
            this.gb_feedback.Controls.Add(this.rb_ProgressBar);
            this.gb_feedback.Controls.Add(this.rb_spinBox);
            this.gb_feedback.Location = new System.Drawing.Point(311, 60);
            this.gb_feedback.Name = "gb_feedback";
            this.gb_feedback.Size = new System.Drawing.Size(174, 100);
            this.gb_feedback.TabIndex = 1;
            this.gb_feedback.TabStop = false;
            this.gb_feedback.Text = "Feedback";
            // 
            // rb_TrackBar
            // 
            this.rb_TrackBar.AutoSize = true;
            this.rb_TrackBar.Location = new System.Drawing.Point(7, 68);
            this.rb_TrackBar.Name = "rb_TrackBar";
            this.rb_TrackBar.Size = new System.Drawing.Size(72, 17);
            this.rb_TrackBar.TabIndex = 2;
            this.rb_TrackBar.TabStop = true;
            this.rb_TrackBar.Text = "Track Bar";
            this.rb_TrackBar.UseVisualStyleBackColor = true;
            // 
            // rb_ProgressBar
            // 
            this.rb_ProgressBar.AutoSize = true;
            this.rb_ProgressBar.Location = new System.Drawing.Point(7, 44);
            this.rb_ProgressBar.Name = "rb_ProgressBar";
            this.rb_ProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rb_ProgressBar.TabIndex = 1;
            this.rb_ProgressBar.TabStop = true;
            this.rb_ProgressBar.Text = "Progress Bar";
            this.rb_ProgressBar.UseVisualStyleBackColor = true;
            // 
            // rb_spinBox
            // 
            this.rb_spinBox.AutoSize = true;
            this.rb_spinBox.Checked = true;
            this.rb_spinBox.Location = new System.Drawing.Point(7, 20);
            this.rb_spinBox.Name = "rb_spinBox";
            this.rb_spinBox.Size = new System.Drawing.Size(67, 17);
            this.rb_spinBox.TabIndex = 0;
            this.rb_spinBox.TabStop = true;
            this.rb_spinBox.Text = "Spin Box";
            this.rb_spinBox.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 219);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(472, 23);
            this.progressBar.TabIndex = 3;
            // 
            // trackbar
            // 
            this.trackbar.Location = new System.Drawing.Point(13, 261);
            this.trackbar.Name = "trackbar";
            this.trackbar.Size = new System.Drawing.Size(472, 45);
            this.trackbar.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(13, 139);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 318);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.trackbar);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.gb_feedback);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_feedback.ResumeLayout(false);
            this.gb_feedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox gb_feedback;
        private System.Windows.Forms.RadioButton rb_TrackBar;
        private System.Windows.Forms.RadioButton rb_ProgressBar;
        private System.Windows.Forms.RadioButton rb_spinBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TrackBar trackbar;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}


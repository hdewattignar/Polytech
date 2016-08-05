namespace Predicate
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
            this.btn_GenerateRandoms = new System.Windows.Forms.Button();
            this.btn_EvenNumbers = new System.Windows.Forms.Button();
            this.btn_LessThanTen = new System.Windows.Forms.Button();
            this.listBox_RandomsDisplay = new System.Windows.Forms.ListBox();
            this.listBox_Sorted = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_GenerateRandoms
            // 
            this.btn_GenerateRandoms.Location = new System.Drawing.Point(13, 13);
            this.btn_GenerateRandoms.Name = "btn_GenerateRandoms";
            this.btn_GenerateRandoms.Size = new System.Drawing.Size(215, 41);
            this.btn_GenerateRandoms.TabIndex = 0;
            this.btn_GenerateRandoms.Text = "Generate Randoms";
            this.btn_GenerateRandoms.UseVisualStyleBackColor = true;
            this.btn_GenerateRandoms.Click += new System.EventHandler(this.btn_GenerateRandoms_Click);
            // 
            // btn_EvenNumbers
            // 
            this.btn_EvenNumbers.Location = new System.Drawing.Point(283, 13);
            this.btn_EvenNumbers.Name = "btn_EvenNumbers";
            this.btn_EvenNumbers.Size = new System.Drawing.Size(215, 41);
            this.btn_EvenNumbers.TabIndex = 1;
            this.btn_EvenNumbers.Text = "Select Even Numbers";
            this.btn_EvenNumbers.UseVisualStyleBackColor = true;
            this.btn_EvenNumbers.Click += new System.EventHandler(this.btn_EvenNumbers_Click);
            // 
            // btn_LessThanTen
            // 
            this.btn_LessThanTen.Location = new System.Drawing.Point(283, 80);
            this.btn_LessThanTen.Name = "btn_LessThanTen";
            this.btn_LessThanTen.Size = new System.Drawing.Size(215, 41);
            this.btn_LessThanTen.TabIndex = 2;
            this.btn_LessThanTen.Text = "Select Numbers < 10";
            this.btn_LessThanTen.UseVisualStyleBackColor = true;
            this.btn_LessThanTen.Click += new System.EventHandler(this.btn_LessThanTen_Click);
            // 
            // listBox_RandomsDisplay
            // 
            this.listBox_RandomsDisplay.FormattingEnabled = true;
            this.listBox_RandomsDisplay.Location = new System.Drawing.Point(13, 167);
            this.listBox_RandomsDisplay.Name = "listBox_RandomsDisplay";
            this.listBox_RandomsDisplay.Size = new System.Drawing.Size(215, 459);
            this.listBox_RandomsDisplay.TabIndex = 3;
            // 
            // listBox_Sorted
            // 
            this.listBox_Sorted.FormattingEnabled = true;
            this.listBox_Sorted.Location = new System.Drawing.Point(283, 167);
            this.listBox_Sorted.Name = "listBox_Sorted";
            this.listBox_Sorted.Size = new System.Drawing.Size(215, 459);
            this.listBox_Sorted.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 685);
            this.Controls.Add(this.listBox_Sorted);
            this.Controls.Add(this.listBox_RandomsDisplay);
            this.Controls.Add(this.btn_LessThanTen);
            this.Controls.Add(this.btn_EvenNumbers);
            this.Controls.Add(this.btn_GenerateRandoms);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GenerateRandoms;
        private System.Windows.Forms.Button btn_EvenNumbers;
        private System.Windows.Forms.Button btn_LessThanTen;
        private System.Windows.Forms.ListBox listBox_RandomsDisplay;
        private System.Windows.Forms.ListBox listBox_Sorted;
    }
}


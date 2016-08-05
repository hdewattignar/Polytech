namespace Lamda_CityDatabase
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
            this.listBox_Display = new System.Windows.Forms.ListBox();
            this.txt_UserInput = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_SearchForPart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Display
            // 
            this.listBox_Display.FormattingEnabled = true;
            this.listBox_Display.Location = new System.Drawing.Point(176, 12);
            this.listBox_Display.Name = "listBox_Display";
            this.listBox_Display.Size = new System.Drawing.Size(402, 407);
            this.listBox_Display.TabIndex = 0;
            // 
            // txt_UserInput
            // 
            this.txt_UserInput.Location = new System.Drawing.Point(13, 12);
            this.txt_UserInput.Name = "txt_UserInput";
            this.txt_UserInput.Size = new System.Drawing.Size(157, 20);
            this.txt_UserInput.TabIndex = 1;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(13, 39);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SearchForPart2
            // 
            this.btn_SearchForPart2.Location = new System.Drawing.Point(13, 97);
            this.btn_SearchForPart2.Name = "btn_SearchForPart2";
            this.btn_SearchForPart2.Size = new System.Drawing.Size(157, 23);
            this.btn_SearchForPart2.TabIndex = 3;
            this.btn_SearchForPart2.Text = "Search for part 2";
            this.btn_SearchForPart2.UseVisualStyleBackColor = true;
            this.btn_SearchForPart2.Click += new System.EventHandler(this.btn_SearchForPart2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 434);
            this.Controls.Add(this.btn_SearchForPart2);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_UserInput);
            this.Controls.Add(this.listBox_Display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Display;
        private System.Windows.Forms.TextBox txt_UserInput;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_SearchForPart2;
    }
}


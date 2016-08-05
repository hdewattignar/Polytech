namespace BridgeGame
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
            this.playButton = new System.Windows.Forms.Button();
            this.scoreDisplay = new System.Windows.Forms.ListBox();
            this.cardDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(65, 377);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // scoreDisplay
            // 
            this.scoreDisplay.FormattingEnabled = true;
            this.scoreDisplay.Location = new System.Drawing.Point(12, 13);
            this.scoreDisplay.Name = "scoreDisplay";
            this.scoreDisplay.Size = new System.Drawing.Size(186, 147);
            this.scoreDisplay.TabIndex = 2;
            // 
            // cardDisplay
            // 
            this.cardDisplay.Location = new System.Drawing.Point(220, 13);
            this.cardDisplay.Name = "cardDisplay";
            this.cardDisplay.Size = new System.Drawing.Size(274, 601);
            this.cardDisplay.TabIndex = 3;
            this.cardDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 626);
            this.Controls.Add(this.cardDisplay);
            this.Controls.Add(this.scoreDisplay);
            this.Controls.Add(this.playButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.ListBox scoreDisplay;
        private System.Windows.Forms.RichTextBox cardDisplay;
    }
}


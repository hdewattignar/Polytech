namespace ComputerBuilder
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
            this.btn_PriceSpec = new System.Windows.Forms.Button();
            this.gb_MachineType = new System.Windows.Forms.GroupBox();
            this.rb_MultiMedia = new System.Windows.Forms.RadioButton();
            this.rb_Business = new System.Windows.Forms.RadioButton();
            this.rb_Game = new System.Windows.Forms.RadioButton();
            this.lb_DisplayBox = new System.Windows.Forms.ListBox();
            this.rb_HighEndGaming = new System.Windows.Forms.RadioButton();
            this.gb_MachineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PriceSpec
            // 
            this.btn_PriceSpec.Location = new System.Drawing.Point(31, 32);
            this.btn_PriceSpec.Name = "btn_PriceSpec";
            this.btn_PriceSpec.Size = new System.Drawing.Size(126, 23);
            this.btn_PriceSpec.TabIndex = 0;
            this.btn_PriceSpec.Text = "Price Spec";
            this.btn_PriceSpec.UseVisualStyleBackColor = true;
            this.btn_PriceSpec.Click += new System.EventHandler(this.btn_PriceSpec_Click);
            // 
            // gb_MachineType
            // 
            this.gb_MachineType.Controls.Add(this.rb_HighEndGaming);
            this.gb_MachineType.Controls.Add(this.rb_MultiMedia);
            this.gb_MachineType.Controls.Add(this.rb_Business);
            this.gb_MachineType.Controls.Add(this.rb_Game);
            this.gb_MachineType.Location = new System.Drawing.Point(31, 95);
            this.gb_MachineType.Name = "gb_MachineType";
            this.gb_MachineType.Size = new System.Drawing.Size(126, 188);
            this.gb_MachineType.TabIndex = 1;
            this.gb_MachineType.TabStop = false;
            this.gb_MachineType.Text = "Machine Type";
            // 
            // rb_MultiMedia
            // 
            this.rb_MultiMedia.AutoSize = true;
            this.rb_MultiMedia.Location = new System.Drawing.Point(6, 113);
            this.rb_MultiMedia.Name = "rb_MultiMedia";
            this.rb_MultiMedia.Size = new System.Drawing.Size(76, 17);
            this.rb_MultiMedia.TabIndex = 2;
            this.rb_MultiMedia.Text = "MultiMedia";
            this.rb_MultiMedia.UseVisualStyleBackColor = true;
            // 
            // rb_Business
            // 
            this.rb_Business.AutoSize = true;
            this.rb_Business.Location = new System.Drawing.Point(6, 69);
            this.rb_Business.Name = "rb_Business";
            this.rb_Business.Size = new System.Drawing.Size(67, 17);
            this.rb_Business.TabIndex = 1;
            this.rb_Business.Text = "Business";
            this.rb_Business.UseVisualStyleBackColor = true;
            // 
            // rb_Game
            // 
            this.rb_Game.AutoSize = true;
            this.rb_Game.Checked = true;
            this.rb_Game.Location = new System.Drawing.Point(7, 29);
            this.rb_Game.Name = "rb_Game";
            this.rb_Game.Size = new System.Drawing.Size(53, 17);
            this.rb_Game.TabIndex = 0;
            this.rb_Game.TabStop = true;
            this.rb_Game.Text = "Game";
            this.rb_Game.UseVisualStyleBackColor = true;
            // 
            // lb_DisplayBox
            // 
            this.lb_DisplayBox.FormattingEnabled = true;
            this.lb_DisplayBox.Location = new System.Drawing.Point(195, 32);
            this.lb_DisplayBox.Name = "lb_DisplayBox";
            this.lb_DisplayBox.Size = new System.Drawing.Size(463, 251);
            this.lb_DisplayBox.TabIndex = 2;
            // 
            // rb_HighEndGaming
            // 
            this.rb_HighEndGaming.AutoSize = true;
            this.rb_HighEndGaming.Location = new System.Drawing.Point(7, 153);
            this.rb_HighEndGaming.Name = "rb_HighEndGaming";
            this.rb_HighEndGaming.Size = new System.Drawing.Size(108, 17);
            this.rb_HighEndGaming.TabIndex = 3;
            this.rb_HighEndGaming.Text = "High End Gaming";
            this.rb_HighEndGaming.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 303);
            this.Controls.Add(this.lb_DisplayBox);
            this.Controls.Add(this.gb_MachineType);
            this.Controls.Add(this.btn_PriceSpec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_MachineType.ResumeLayout(false);
            this.gb_MachineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PriceSpec;
        private System.Windows.Forms.GroupBox gb_MachineType;
        private System.Windows.Forms.RadioButton rb_MultiMedia;
        private System.Windows.Forms.RadioButton rb_Business;
        private System.Windows.Forms.RadioButton rb_Game;
        private System.Windows.Forms.ListBox lb_DisplayBox;
        private System.Windows.Forms.RadioButton rb_HighEndGaming;
    }
}


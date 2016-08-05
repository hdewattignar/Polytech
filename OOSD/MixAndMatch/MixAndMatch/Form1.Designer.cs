namespace MixAndMatch
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
            this.pb_Head = new System.Windows.Forms.PictureBox();
            this.pb_Body = new System.Windows.Forms.PictureBox();
            this.pb_Feet = new System.Windows.Forms.PictureBox();
            this.lb_Head = new System.Windows.Forms.Label();
            this.lb_Body = new System.Windows.Forms.Label();
            this.lb_Feet = new System.Windows.Forms.Label();
            this.cb_Head = new System.Windows.Forms.ComboBox();
            this.cb_Body = new System.Windows.Forms.ComboBox();
            this.cb_Feet = new System.Windows.Forms.ComboBox();
            this.btn_MakeMonster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Feet)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Head
            // 
            this.pb_Head.Location = new System.Drawing.Point(13, 13);
            this.pb_Head.Name = "pb_Head";
            this.pb_Head.Size = new System.Drawing.Size(452, 327);
            this.pb_Head.TabIndex = 0;
            this.pb_Head.TabStop = false;
            // 
            // pb_Body
            // 
            this.pb_Body.Location = new System.Drawing.Point(13, 346);
            this.pb_Body.Name = "pb_Body";
            this.pb_Body.Size = new System.Drawing.Size(452, 266);
            this.pb_Body.TabIndex = 1;
            this.pb_Body.TabStop = false;
            // 
            // pb_Feet
            // 
            this.pb_Feet.Location = new System.Drawing.Point(12, 618);
            this.pb_Feet.Name = "pb_Feet";
            this.pb_Feet.Size = new System.Drawing.Size(452, 266);
            this.pb_Feet.TabIndex = 2;
            this.pb_Feet.TabStop = false;
            // 
            // lb_Head
            // 
            this.lb_Head.AutoSize = true;
            this.lb_Head.Location = new System.Drawing.Point(494, 41);
            this.lb_Head.Name = "lb_Head";
            this.lb_Head.Size = new System.Drawing.Size(33, 13);
            this.lb_Head.TabIndex = 3;
            this.lb_Head.Text = "Head";
            // 
            // lb_Body
            // 
            this.lb_Body.AutoSize = true;
            this.lb_Body.Location = new System.Drawing.Point(494, 97);
            this.lb_Body.Name = "lb_Body";
            this.lb_Body.Size = new System.Drawing.Size(31, 13);
            this.lb_Body.TabIndex = 4;
            this.lb_Body.Text = "Body";
            // 
            // lb_Feet
            // 
            this.lb_Feet.AutoSize = true;
            this.lb_Feet.Location = new System.Drawing.Point(494, 156);
            this.lb_Feet.Name = "lb_Feet";
            this.lb_Feet.Size = new System.Drawing.Size(28, 13);
            this.lb_Feet.TabIndex = 5;
            this.lb_Feet.Text = "Feet";
            // 
            // cb_Head
            // 
            this.cb_Head.FormattingEnabled = true;
            this.cb_Head.Location = new System.Drawing.Point(563, 38);
            this.cb_Head.Name = "cb_Head";
            this.cb_Head.Size = new System.Drawing.Size(233, 21);
            this.cb_Head.TabIndex = 6;
            // 
            // cb_Body
            // 
            this.cb_Body.FormattingEnabled = true;
            this.cb_Body.Location = new System.Drawing.Point(563, 94);
            this.cb_Body.Name = "cb_Body";
            this.cb_Body.Size = new System.Drawing.Size(233, 21);
            this.cb_Body.TabIndex = 7;
            // 
            // cb_Feet
            // 
            this.cb_Feet.FormattingEnabled = true;
            this.cb_Feet.Location = new System.Drawing.Point(563, 153);
            this.cb_Feet.Name = "cb_Feet";
            this.cb_Feet.Size = new System.Drawing.Size(233, 21);
            this.cb_Feet.TabIndex = 8;
            // 
            // btn_MakeMonster
            // 
            this.btn_MakeMonster.Location = new System.Drawing.Point(624, 214);
            this.btn_MakeMonster.Name = "btn_MakeMonster";
            this.btn_MakeMonster.Size = new System.Drawing.Size(171, 23);
            this.btn_MakeMonster.TabIndex = 9;
            this.btn_MakeMonster.Text = "Make Monster";
            this.btn_MakeMonster.UseVisualStyleBackColor = true;
            this.btn_MakeMonster.Click += new System.EventHandler(this.btn_MakeMonster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 926);
            this.Controls.Add(this.btn_MakeMonster);
            this.Controls.Add(this.cb_Feet);
            this.Controls.Add(this.cb_Body);
            this.Controls.Add(this.cb_Head);
            this.Controls.Add(this.lb_Feet);
            this.Controls.Add(this.lb_Body);
            this.Controls.Add(this.lb_Head);
            this.Controls.Add(this.pb_Feet);
            this.Controls.Add(this.pb_Body);
            this.Controls.Add(this.pb_Head);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Feet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Head;
        private System.Windows.Forms.PictureBox pb_Body;
        private System.Windows.Forms.PictureBox pb_Feet;
        private System.Windows.Forms.Label lb_Head;
        private System.Windows.Forms.Label lb_Body;
        private System.Windows.Forms.Label lb_Feet;
        private System.Windows.Forms.ComboBox cb_Head;
        private System.Windows.Forms.ComboBox cb_Body;
        private System.Windows.Forms.ComboBox cb_Feet;
        private System.Windows.Forms.Button btn_MakeMonster;
    }
}


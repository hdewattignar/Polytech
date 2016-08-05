namespace AnimalWorld
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
            this.lb_Display = new System.Windows.Forms.ListBox();
            this.btn_NorthAmerica = new System.Windows.Forms.Button();
            this.btn_Australia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Africa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Display
            // 
            this.lb_Display.FormattingEnabled = true;
            this.lb_Display.Location = new System.Drawing.Point(153, 13);
            this.lb_Display.Name = "lb_Display";
            this.lb_Display.Size = new System.Drawing.Size(403, 355);
            this.lb_Display.TabIndex = 4;
            // 
            // btn_NorthAmerica
            // 
            this.btn_NorthAmerica.Location = new System.Drawing.Point(153, 395);
            this.btn_NorthAmerica.Name = "btn_NorthAmerica";
            this.btn_NorthAmerica.Size = new System.Drawing.Size(100, 30);
            this.btn_NorthAmerica.TabIndex = 5;
            this.btn_NorthAmerica.Text = "North America";
            this.btn_NorthAmerica.UseVisualStyleBackColor = true;
            this.btn_NorthAmerica.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Australia
            // 
            this.btn_Australia.Location = new System.Drawing.Point(456, 395);
            this.btn_Australia.Name = "btn_Australia";
            this.btn_Australia.Size = new System.Drawing.Size(100, 30);
            this.btn_Australia.TabIndex = 6;
            this.btn_Australia.Text = "Australia";
            this.btn_Australia.UseVisualStyleBackColor = true;
            this.btn_Australia.Click += new System.EventHandler(this.btn_Australia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(13, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(13, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Africa
            // 
            this.btn_Africa.Location = new System.Drawing.Point(308, 395);
            this.btn_Africa.Name = "btn_Africa";
            this.btn_Africa.Size = new System.Drawing.Size(100, 30);
            this.btn_Africa.TabIndex = 11;
            this.btn_Africa.Text = "Africa";
            this.btn_Africa.UseVisualStyleBackColor = true;
            this.btn_Africa.Click += new System.EventHandler(this.btn_Africa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.btn_Africa);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Australia);
            this.Controls.Add(this.btn_NorthAmerica);
            this.Controls.Add(this.lb_Display);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Display;
        private System.Windows.Forms.Button btn_NorthAmerica;
        private System.Windows.Forms.Button btn_Australia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_Africa;
    }
}


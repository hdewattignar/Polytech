namespace CustomControlHandler
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
            this.btn_testHandlers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_testHandlers
            // 
            this.btn_testHandlers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testHandlers.Location = new System.Drawing.Point(13, 13);
            this.btn_testHandlers.Name = "btn_testHandlers";
            this.btn_testHandlers.Size = new System.Drawing.Size(259, 115);
            this.btn_testHandlers.TabIndex = 0;
            this.btn_testHandlers.Text = "Test Handlers";
            this.btn_testHandlers.UseVisualStyleBackColor = true;
            this.btn_testHandlers.Click += new System.EventHandler(this.btn_testHandlers_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.btn_testHandlers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_testHandlers;
    }
}


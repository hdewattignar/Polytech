namespace QuizNight_Delegate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Adult = new System.Windows.Forms.RadioButton();
            this.rb_Child = new System.Windows.Forms.RadioButton();
            this.btn_ComputeScore = new System.Windows.Forms.Button();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CorrectAnswers = new System.Windows.Forms.TextBox();
            this.tb_IncorrectAnswers = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Child);
            this.groupBox1.Controls.Add(this.rb_Adult);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Type";
            // 
            // rb_Adult
            // 
            this.rb_Adult.AutoSize = true;
            this.rb_Adult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Adult.Location = new System.Drawing.Point(6, 32);
            this.rb_Adult.Name = "rb_Adult";
            this.rb_Adult.Size = new System.Drawing.Size(64, 24);
            this.rb_Adult.TabIndex = 0;
            this.rb_Adult.TabStop = true;
            this.rb_Adult.Text = "Adult";
            this.rb_Adult.UseVisualStyleBackColor = true;
            // 
            // rb_Child
            // 
            this.rb_Child.AutoSize = true;
            this.rb_Child.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Child.Location = new System.Drawing.Point(6, 66);
            this.rb_Child.Name = "rb_Child";
            this.rb_Child.Size = new System.Drawing.Size(62, 24);
            this.rb_Child.TabIndex = 1;
            this.rb_Child.TabStop = true;
            this.rb_Child.Text = "Child";
            this.rb_Child.UseVisualStyleBackColor = true;
            // 
            // btn_ComputeScore
            // 
            this.btn_ComputeScore.Location = new System.Drawing.Point(13, 203);
            this.btn_ComputeScore.Name = "btn_ComputeScore";
            this.btn_ComputeScore.Size = new System.Drawing.Size(143, 49);
            this.btn_ComputeScore.TabIndex = 1;
            this.btn_ComputeScore.Text = "Compute Score";
            this.btn_ComputeScore.UseVisualStyleBackColor = true;
            this.btn_ComputeScore.Click += new System.EventHandler(this.btn_ComputeScore_Click);
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Score.Location = new System.Drawing.Point(197, 210);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(39, 42);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correct Answers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incorrect Answers";
            // 
            // tb_CorrectAnswers
            // 
            this.tb_CorrectAnswers.Location = new System.Drawing.Point(355, 45);
            this.tb_CorrectAnswers.Name = "tb_CorrectAnswers";
            this.tb_CorrectAnswers.Size = new System.Drawing.Size(135, 20);
            this.tb_CorrectAnswers.TabIndex = 5;
            this.tb_CorrectAnswers.Text = "10";
            // 
            // tb_IncorrectAnswers
            // 
            this.tb_IncorrectAnswers.Location = new System.Drawing.Point(355, 78);
            this.tb_IncorrectAnswers.Name = "tb_IncorrectAnswers";
            this.tb_IncorrectAnswers.Size = new System.Drawing.Size(135, 20);
            this.tb_IncorrectAnswers.TabIndex = 6;
            this.tb_IncorrectAnswers.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 312);
            this.Controls.Add(this.tb_IncorrectAnswers);
            this.Controls.Add(this.tb_CorrectAnswers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.btn_ComputeScore);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Child;
        private System.Windows.Forms.RadioButton rb_Adult;
        private System.Windows.Forms.Button btn_ComputeScore;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CorrectAnswers;
        private System.Windows.Forms.TextBox tb_IncorrectAnswers;
    }
}


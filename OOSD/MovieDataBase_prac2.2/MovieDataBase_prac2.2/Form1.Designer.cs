namespace MovieDataBase_prac2._2
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
            this.btn_AddMovie = new System.Windows.Forms.Button();
            this.lbl_AddMovieYear = new System.Windows.Forms.Label();
            this.lbl_AddMovieTitle = new System.Windows.Forms.Label();
            this.lbl_AddMovieDirector = new System.Windows.Forms.Label();
            this.txt_AddMovieYear = new System.Windows.Forms.TextBox();
            this.txt_AddMovieTitle = new System.Windows.Forms.TextBox();
            this.txt_AddMovieDirector = new System.Windows.Forms.TextBox();
            this.btn_DeleteMovie = new System.Windows.Forms.Button();
            this.txt_DeleteYear = new System.Windows.Forms.TextBox();
            this.lbl_DeleteYear = new System.Windows.Forms.Label();
            this.btn_SearchMovie = new System.Windows.Forms.Button();
            this.lbl_SearchYear = new System.Windows.Forms.Label();
            this.txt_SearchYear = new System.Windows.Forms.TextBox();
            this.btn_PrintAll = new System.Windows.Forms.Button();
            this.lb_PrintAllDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.Location = new System.Drawing.Point(12, 34);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_AddMovie.TabIndex = 0;
            this.btn_AddMovie.Text = "Add Movie";
            this.btn_AddMovie.UseVisualStyleBackColor = true;
            this.btn_AddMovie.Click += new System.EventHandler(this.btn_AddMovie_Click);
            // 
            // lbl_AddMovieYear
            // 
            this.lbl_AddMovieYear.AutoSize = true;
            this.lbl_AddMovieYear.Location = new System.Drawing.Point(137, 34);
            this.lbl_AddMovieYear.Name = "lbl_AddMovieYear";
            this.lbl_AddMovieYear.Size = new System.Drawing.Size(29, 13);
            this.lbl_AddMovieYear.TabIndex = 1;
            this.lbl_AddMovieYear.Text = "Year";
            // 
            // lbl_AddMovieTitle
            // 
            this.lbl_AddMovieTitle.AutoSize = true;
            this.lbl_AddMovieTitle.Location = new System.Drawing.Point(137, 66);
            this.lbl_AddMovieTitle.Name = "lbl_AddMovieTitle";
            this.lbl_AddMovieTitle.Size = new System.Drawing.Size(27, 13);
            this.lbl_AddMovieTitle.TabIndex = 2;
            this.lbl_AddMovieTitle.Text = "Title";
            // 
            // lbl_AddMovieDirector
            // 
            this.lbl_AddMovieDirector.AutoSize = true;
            this.lbl_AddMovieDirector.Location = new System.Drawing.Point(137, 98);
            this.lbl_AddMovieDirector.Name = "lbl_AddMovieDirector";
            this.lbl_AddMovieDirector.Size = new System.Drawing.Size(44, 13);
            this.lbl_AddMovieDirector.TabIndex = 3;
            this.lbl_AddMovieDirector.Text = "Director";
            // 
            // txt_AddMovieYear
            // 
            this.txt_AddMovieYear.Location = new System.Drawing.Point(218, 34);
            this.txt_AddMovieYear.Name = "txt_AddMovieYear";
            this.txt_AddMovieYear.Size = new System.Drawing.Size(417, 20);
            this.txt_AddMovieYear.TabIndex = 4;
            // 
            // txt_AddMovieTitle
            // 
            this.txt_AddMovieTitle.Location = new System.Drawing.Point(218, 66);
            this.txt_AddMovieTitle.Name = "txt_AddMovieTitle";
            this.txt_AddMovieTitle.Size = new System.Drawing.Size(417, 20);
            this.txt_AddMovieTitle.TabIndex = 5;
            // 
            // txt_AddMovieDirector
            // 
            this.txt_AddMovieDirector.Location = new System.Drawing.Point(218, 98);
            this.txt_AddMovieDirector.Name = "txt_AddMovieDirector";
            this.txt_AddMovieDirector.Size = new System.Drawing.Size(417, 20);
            this.txt_AddMovieDirector.TabIndex = 6;
            // 
            // btn_DeleteMovie
            // 
            this.btn_DeleteMovie.Location = new System.Drawing.Point(12, 178);
            this.btn_DeleteMovie.Name = "btn_DeleteMovie";
            this.btn_DeleteMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteMovie.TabIndex = 7;
            this.btn_DeleteMovie.Text = "Delete Movie";
            this.btn_DeleteMovie.UseVisualStyleBackColor = true;
            this.btn_DeleteMovie.Click += new System.EventHandler(this.btn_DeleteMovie_Click);
            // 
            // txt_DeleteYear
            // 
            this.txt_DeleteYear.Location = new System.Drawing.Point(218, 181);
            this.txt_DeleteYear.Name = "txt_DeleteYear";
            this.txt_DeleteYear.Size = new System.Drawing.Size(417, 20);
            this.txt_DeleteYear.TabIndex = 8;
            // 
            // lbl_DeleteYear
            // 
            this.lbl_DeleteYear.AutoSize = true;
            this.lbl_DeleteYear.Location = new System.Drawing.Point(140, 181);
            this.lbl_DeleteYear.Name = "lbl_DeleteYear";
            this.lbl_DeleteYear.Size = new System.Drawing.Size(29, 13);
            this.lbl_DeleteYear.TabIndex = 9;
            this.lbl_DeleteYear.Text = "Year";
            // 
            // btn_SearchMovie
            // 
            this.btn_SearchMovie.Location = new System.Drawing.Point(12, 277);
            this.btn_SearchMovie.Name = "btn_SearchMovie";
            this.btn_SearchMovie.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchMovie.TabIndex = 10;
            this.btn_SearchMovie.Text = "Search";
            this.btn_SearchMovie.UseVisualStyleBackColor = true;
            this.btn_SearchMovie.Click += new System.EventHandler(this.btn_SearchMovie_Click);
            // 
            // lbl_SearchYear
            // 
            this.lbl_SearchYear.AutoSize = true;
            this.lbl_SearchYear.Location = new System.Drawing.Point(140, 279);
            this.lbl_SearchYear.Name = "lbl_SearchYear";
            this.lbl_SearchYear.Size = new System.Drawing.Size(29, 13);
            this.lbl_SearchYear.TabIndex = 11;
            this.lbl_SearchYear.Text = "Year";
            // 
            // txt_SearchYear
            // 
            this.txt_SearchYear.Location = new System.Drawing.Point(218, 279);
            this.txt_SearchYear.Name = "txt_SearchYear";
            this.txt_SearchYear.Size = new System.Drawing.Size(417, 20);
            this.txt_SearchYear.TabIndex = 12;
            // 
            // btn_PrintAll
            // 
            this.btn_PrintAll.Location = new System.Drawing.Point(12, 367);
            this.btn_PrintAll.Name = "btn_PrintAll";
            this.btn_PrintAll.Size = new System.Drawing.Size(75, 23);
            this.btn_PrintAll.TabIndex = 14;
            this.btn_PrintAll.Text = "Print All";
            this.btn_PrintAll.UseVisualStyleBackColor = true;
            this.btn_PrintAll.Click += new System.EventHandler(this.btn_PrintAll_Click);
            // 
            // lb_PrintAllDisplay
            // 
            this.lb_PrintAllDisplay.FormattingEnabled = true;
            this.lb_PrintAllDisplay.Location = new System.Drawing.Point(140, 367);
            this.lb_PrintAllDisplay.Name = "lb_PrintAllDisplay";
            this.lb_PrintAllDisplay.Size = new System.Drawing.Size(495, 264);
            this.lb_PrintAllDisplay.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 642);
            this.Controls.Add(this.lb_PrintAllDisplay);
            this.Controls.Add(this.btn_PrintAll);
            this.Controls.Add(this.txt_SearchYear);
            this.Controls.Add(this.lbl_SearchYear);
            this.Controls.Add(this.btn_SearchMovie);
            this.Controls.Add(this.lbl_DeleteYear);
            this.Controls.Add(this.txt_DeleteYear);
            this.Controls.Add(this.btn_DeleteMovie);
            this.Controls.Add(this.txt_AddMovieDirector);
            this.Controls.Add(this.txt_AddMovieTitle);
            this.Controls.Add(this.txt_AddMovieYear);
            this.Controls.Add(this.lbl_AddMovieDirector);
            this.Controls.Add(this.lbl_AddMovieTitle);
            this.Controls.Add(this.lbl_AddMovieYear);
            this.Controls.Add(this.btn_AddMovie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddMovie;
        private System.Windows.Forms.Label lbl_AddMovieYear;
        private System.Windows.Forms.Label lbl_AddMovieTitle;
        private System.Windows.Forms.Label lbl_AddMovieDirector;
        private System.Windows.Forms.TextBox txt_AddMovieYear;
        private System.Windows.Forms.TextBox txt_AddMovieTitle;
        private System.Windows.Forms.TextBox txt_AddMovieDirector;
        private System.Windows.Forms.Button btn_DeleteMovie;
        private System.Windows.Forms.TextBox txt_DeleteYear;
        private System.Windows.Forms.Label lbl_DeleteYear;
        private System.Windows.Forms.Button btn_SearchMovie;
        private System.Windows.Forms.Label lbl_SearchYear;
        private System.Windows.Forms.TextBox txt_SearchYear;
        private System.Windows.Forms.Button btn_PrintAll;
        private System.Windows.Forms.ListBox lb_PrintAllDisplay;
    }
}


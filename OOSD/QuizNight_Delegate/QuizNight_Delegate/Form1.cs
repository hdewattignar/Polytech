using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizNight_Delegate
{
    

    public partial class Form1 : Form
    {

        public delegate int ScoreDelegate(int correct, int Incorrect);
        private ScoreDelegate scoreComputer;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ComputeScore_Click(object sender, EventArgs e)
        {
            if (rb_Adult.Checked == true)
            {
                scoreComputer = new ScoreDelegate(Scorer.AdultScore);
            }
            else
                scoreComputer = new ScoreDelegate(Scorer.ChildScore);

            int correct = Convert.ToInt32(tb_CorrectAnswers.Text);
            int incorrect = Convert.ToInt32(tb_IncorrectAnswers.Text);
            int score = scoreComputer(correct, incorrect);

            lbl_Score.Text = Convert.ToString(score);

        }
    }
}

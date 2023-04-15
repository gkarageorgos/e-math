using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_math
{
    public partial class Chapter4Form : Form
    {
        private String username;
        public Chapter4Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter4Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.scores[3].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score4 = 0;
            if (answer1TextBox.Text == "3/2")
            {
                score4 += 3;
            }
            if (answer2TextBox.Text == "19/15")
            {
                score4 += 5;
            }
            if (answer3TextBox.Text == "16/15")
            {
                score4 += 10;
            }
            scoreTextBox.Text = score4.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score4, 4);
            s.closeConnection();
        }
    }
}

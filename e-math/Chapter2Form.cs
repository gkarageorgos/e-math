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
    public partial class Chapter2Form : Form
    {
        private String username;
        public Chapter2Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter2Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.scores[1].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score2 = 0;
            if (answer1TextBox.Text == "18/45")
            {
                score2 += 3;
            }
            if (correctRadioButton.Checked)
            {
                score2 += 5;
            }
            if (answer3TextBox.Text == "5/7")
            {
                score2 += 10;                
            }
            scoreTextBox.Text = score2.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score2, 2);
            s.closeConnection();
        }
    }
}

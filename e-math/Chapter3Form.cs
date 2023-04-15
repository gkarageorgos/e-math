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
    public partial class Chapter3Form : Form
    {
        private String username;
        public Chapter3Form(String username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void Chapter3Form_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = username;
            scoreTextBox.Text = MainForm.instance.scores[2].ToString();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            int score3 = 0;
            if (answer1TextBox.Text == "5/7")
            {
                score3 += 3;
            }
            if (correctRadioButton.Checked)
            {
                score3 += 5;
            }
            if (answer3TextBox.Text == "5")
            {
                score3 += 10;
            }
            scoreTextBox.Text = score3.ToString();
            Score s = new Score();
            s.openConnection();
            s.update(username, score3, 3);
            s.closeConnection();
        }
    }
}


namespace e_math
{
    partial class Chapter3Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.answerButton = new System.Windows.Forms.Button();
            this.correctRadioButton = new System.Windows.Forms.RadioButton();
            this.falseRadioButton = new System.Windows.Forms.RadioButton();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.answer3TextBox = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.answer1TextBox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(483, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "score:";
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.scoreTextBox.ForeColor = System.Drawing.Color.Red;
            this.scoreTextBox.Location = new System.Drawing.Point(592, 9);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.ReadOnly = true;
            this.scoreTextBox.Size = new System.Drawing.Size(108, 30);
            this.scoreTextBox.TabIndex = 14;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Red;
            this.usernameTextBox.Location = new System.Drawing.Point(147, 9);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(167, 30);
            this.usernameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "username:";
            // 
            // answerButton
            // 
            this.answerButton.BackColor = System.Drawing.Color.White;
            this.answerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answerButton.ForeColor = System.Drawing.Color.Green;
            this.answerButton.Location = new System.Drawing.Point(521, 569);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(190, 62);
            this.answerButton.TabIndex = 16;
            this.answerButton.Text = "Υποβολή Απάντησης";
            this.answerButton.UseVisualStyleBackColor = false;
            this.answerButton.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // correctRadioButton
            // 
            this.correctRadioButton.AutoSize = true;
            this.correctRadioButton.Location = new System.Drawing.Point(641, 313);
            this.correctRadioButton.Name = "correctRadioButton";
            this.correctRadioButton.Size = new System.Drawing.Size(70, 21);
            this.correctRadioButton.TabIndex = 30;
            this.correctRadioButton.TabStop = true;
            this.correctRadioButton.Text = "Λάθος";
            this.correctRadioButton.UseVisualStyleBackColor = true;
            // 
            // falseRadioButton
            // 
            this.falseRadioButton.AutoSize = true;
            this.falseRadioButton.Location = new System.Drawing.Point(539, 313);
            this.falseRadioButton.Name = "falseRadioButton";
            this.falseRadioButton.Size = new System.Drawing.Size(70, 21);
            this.falseRadioButton.TabIndex = 29;
            this.falseRadioButton.TabStop = true;
            this.falseRadioButton.Text = "Σωστό";
            this.falseRadioButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox3.Location = new System.Drawing.Point(12, 409);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(451, 84);
            this.richTextBox3.TabIndex = 28;
            this.richTextBox3.Text = "3. Να βρείτε το φυσικό αριθμό μεταξύ των κλασμάτων: 21/5 και 29/5.";
            // 
            // answer3TextBox
            // 
            this.answer3TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answer3TextBox.ForeColor = System.Drawing.Color.Blue;
            this.answer3TextBox.Location = new System.Drawing.Point(618, 463);
            this.answer3TextBox.Name = "answer3TextBox";
            this.answer3TextBox.Size = new System.Drawing.Size(93, 30);
            this.answer3TextBox.TabIndex = 27;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox2.Location = new System.Drawing.Point(17, 256);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(451, 78);
            this.richTextBox2.TabIndex = 26;
            this.richTextBox2.Text = "2. Το κλάσμα 8/12 είναι μεγαλύτερο από το 4/5.";
            // 
            // answer1TextBox
            // 
            this.answer1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.answer1TextBox.ForeColor = System.Drawing.Color.Blue;
            this.answer1TextBox.Location = new System.Drawing.Point(618, 160);
            this.answer1TextBox.Name = "answer1TextBox";
            this.answer1TextBox.Size = new System.Drawing.Size(93, 30);
            this.answer1TextBox.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.richTextBox1.Location = new System.Drawing.Point(17, 106);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 84);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "1. Ποιο από τα ακόλουθα κλάσματα είναι το μεγαλύτερο 3/7 ή 5/7;";
            // 
            // Chapter3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 660);
            this.Controls.Add(this.correctRadioButton);
            this.Controls.Add(this.falseRadioButton);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.answer3TextBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.answer1TextBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.answerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Chapter3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chapter3Form";
            this.Load += new System.EventHandler(this.Chapter3Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button answerButton;
        private System.Windows.Forms.RadioButton correctRadioButton;
        private System.Windows.Forms.RadioButton falseRadioButton;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox answer3TextBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox answer1TextBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}